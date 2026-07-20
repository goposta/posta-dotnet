using System.Net;
using Microsoft.Extensions.Logging;
using Posta.Configuration;
using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Tests;

public sealed class PostaTransportTests
{
    [Fact]
    public async Task SendAsyncExpandsPathAndWritesRepeatedQueryValues()
    {
        Uri? requestUri = null;
        string? authorization = null;
        string? customHeader = null;
        var handler = new TestHttpMessageHandler((request, _) =>
        {
            requestUri = request.RequestUri;
            authorization = request.Headers.Authorization?.Parameter;
            customHeader = request.Headers.GetValues("X-Test").Single();
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.NoContent));
        });
        using var httpClient = CreateHttpClient(handler);
        var transport = new PostaTransport(httpClient, new FixedCredentialProvider("configured"));
        var endpoint = new PostaEndpoint(HttpMethod.Get, "/items/{id}", PostaAuthentication.AccessToken);
        var request = new PostaRequest
        {
            PathParameters = new Dictionary<string, object?> { ["id"] = "a/b" },
            Query = new Dictionary<string, object?>
            {
                ["tag"] = new[] { "one", "two words" },
                ["enabled"] = true,
                ["ignored"] = null
            },
            Headers = new Dictionary<string, string> { ["X-Test"] = "value" },
            BearerToken = "override"
        };

        object? response = await transport.SendAsync<object>(endpoint, request, CancellationToken.None);

        Assert.Null(response);
        Assert.Equal(
            "https://posta.example.com/items/a%2Fb?tag=one&tag=two%20words&enabled=true",
            requestUri?.AbsoluteUri);
        Assert.Equal("override", authorization);
        Assert.Equal("value", customHeader);
    }

    [Fact]
    public async Task SendAsyncThrowsApiExceptionForErrorResponse()
    {
        var handler = new TestHttpMessageHandler((_, _) => Task.FromResult(
            new HttpResponseMessage(HttpStatusCode.UnprocessableEntity)
            {
                Content = new StringContent("{\"error\":\"invalid email\"}")
            }));
        using var httpClient = CreateHttpClient(handler);
        var transport = new PostaTransport(httpClient, new FixedCredentialProvider(null));
        var endpoint = new PostaEndpoint(HttpMethod.Post, "/verify", PostaAuthentication.None);

        PostaApiException exception = await Assert.ThrowsAsync<PostaApiException>(
            () => transport.SendAsync<object>(endpoint, null, CancellationToken.None));

        Assert.Equal(HttpStatusCode.UnprocessableEntity, exception.StatusCode);
        Assert.Equal("{\"error\":\"invalid email\"}", exception.ResponseBody);
        Assert.Contains("POST /verify", exception.Message, StringComparison.Ordinal);
    }

    [Theory]
    [InlineData(HttpStatusCode.Unauthorized, LogLevel.Warning)]
    [InlineData(HttpStatusCode.NotFound, LogLevel.Warning)]
    [InlineData(HttpStatusCode.TooManyRequests, LogLevel.Warning)]
    [InlineData(HttpStatusCode.InternalServerError, LogLevel.Error)]
    public async Task SendAsyncLogsDocumentedErrorResponses(HttpStatusCode statusCode, LogLevel expectedLevel)
    {
        const string responseBody = """
            {"success":false,"data":null,"error":{"code":"resource_not_found","error":"NotFound","message":"Resource was not found"}}
            """;
        var handler = new TestHttpMessageHandler((_, _) => Task.FromResult(
            new HttpResponseMessage(statusCode)
            {
                Content = new StringContent(responseBody)
            }));
        using var httpClient = CreateHttpClient(handler);
        var logger = new CapturingLogger();
        var transport = new PostaTransport(httpClient, new FixedCredentialProvider(null), logger);
        var endpoint = new PostaEndpoint(HttpMethod.Get, "/resources/missing", PostaAuthentication.None);

        PostaApiException exception = await Assert.ThrowsAsync<PostaApiException>(
            () => transport.SendAsync<object>(endpoint, null, CancellationToken.None));

        Assert.Equal("resource_not_found", exception.Error?.Code);
        Assert.Equal("NotFound", exception.Error?.Type);
        Assert.Equal("Resource was not found", exception.Error?.Message);
        Assert.Equal(expectedLevel, logger.Level);
        Assert.Equal((int)statusCode, logger.EventId.Id);
        Assert.Contains("/resources/missing", logger.Message, StringComparison.Ordinal);
        Assert.Contains("resource_not_found", logger.Message, StringComparison.Ordinal);
    }

    [Fact]
    public async Task SendAsyncRejectsMissingCredentialBeforeSendingRequest()
    {
        var handler = new TestHttpMessageHandler((_, _) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)));
        using var httpClient = CreateHttpClient(handler);
        var transport = new PostaTransport(httpClient, new FixedCredentialProvider(null));
        var endpoint = new PostaEndpoint(HttpMethod.Get, "/private", PostaAuthentication.ApiKey);

        InvalidOperationException exception = await Assert.ThrowsAsync<InvalidOperationException>(
            () => transport.SendAsync<object>(endpoint, null, CancellationToken.None));

        Assert.Contains("ApiKey", exception.Message, StringComparison.Ordinal);
        Assert.Equal(0, handler.RequestCount);
    }

    [Fact]
    public async Task SendAsyncRejectsIncompleteEndpointBeforeSendingRequest()
    {
        var handler = new TestHttpMessageHandler((_, _) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)));
        using var httpClient = CreateHttpClient(handler);
        var transport = new PostaTransport(httpClient, new FixedCredentialProvider(null));
        var endpoint = new PostaEndpoint(
            HttpMethod.Get,
            "/unsupported",
            PostaAuthentication.None,
            false,
            "Missing response schema.");

        NotSupportedException exception = await Assert.ThrowsAsync<NotSupportedException>(
            () => transport.SendAsync<object>(endpoint, null, CancellationToken.None));

        Assert.Contains("Missing response schema.", exception.Message, StringComparison.Ordinal);
        Assert.Equal(0, handler.RequestCount);
    }

    [Fact]
    public async Task SendAsyncRequiresEveryPathParameter()
    {
        var handler = new TestHttpMessageHandler((_, _) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)));
        using var httpClient = CreateHttpClient(handler);
        var transport = new PostaTransport(httpClient, new FixedCredentialProvider(null));
        var endpoint = new PostaEndpoint(HttpMethod.Get, "/items/{id}", PostaAuthentication.None);

        ArgumentException exception = await Assert.ThrowsAsync<ArgumentException>(
            () => transport.SendAsync<object>(endpoint, null, CancellationToken.None));

        Assert.Equal("values", exception.ParamName);
        Assert.Equal(0, handler.RequestCount);
    }

    [Fact]
    public async Task SendAsyncRejectsBodyAndContentTogether()
    {
        var handler = new TestHttpMessageHandler((_, _) =>
            Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)));
        using var httpClient = CreateHttpClient(handler);
        var transport = new PostaTransport(httpClient, new FixedCredentialProvider(null));
        var endpoint = new PostaEndpoint(HttpMethod.Post, "/items", PostaAuthentication.None);
        var request = new PostaRequest
        {
            Body = new { Value = 1 },
            Content = new StringContent("content")
        };

        ArgumentException exception = await Assert.ThrowsAsync<ArgumentException>(
            () => transport.SendAsync<object>(endpoint, request, CancellationToken.None));

        Assert.Equal("request", exception.ParamName);
        Assert.Equal(0, handler.RequestCount);
    }

    private static HttpClient CreateHttpClient(HttpMessageHandler handler) => new(handler)
    {
        BaseAddress = new Uri("https://posta.example.com")
    };

    private sealed class FixedCredentialProvider(string? credential) : IPostaCredentialProvider
    {
        public ValueTask<string?> GetCredentialAsync(
            PostaAuthentication authentication,
            CancellationToken cancellationToken = default) => ValueTask.FromResult(credential);
    }

    private sealed class CapturingLogger : ILogger
    {
        public LogLevel Level { get; private set; }

        public EventId EventId { get; private set; }

        public string Message { get; private set; } = string.Empty;

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        public void Log<TState>(
            LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception? exception,
            Func<TState, Exception?, string> formatter)
        {
            Level = logLevel;
            EventId = eventId;
            Message = formatter(state, exception);
        }
    }
}
