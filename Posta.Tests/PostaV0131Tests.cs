using System.Net;
using System.Security.Cryptography;
using System.Text;
using Posta.Clients;
using Posta.Configuration;
using Posta.Endpoints;
using Posta.Models.Subscribers;
using Posta.Models.Templates;
using Posta.Security;

namespace Posta.Tests;

public sealed class PostaV0131Tests
{
    [Fact]
    public async Task CsvImportSendsDocumentedMultipartFields()
    {
        string? body = null;
        var handler = new TestHttpMessageHandler(async (request, cancellationToken) =>
        {
            body = await request.Content!.ReadAsStringAsync(cancellationToken);
            Assert.Equal("multipart/form-data", request.Content.Headers.ContentType?.MediaType);
            return JsonResponse("{\"success\":true}");
        });
        using var http = new HttpClient(handler) { BaseAddress = new Uri("https://posta.example.com") };
        using var client = new PostaClient(http, new FixedCredentialProvider("token"));

        await client.Subscribers.BulkImportSubscribersCsvAsync(new BulkImportSubscribersCsvRequest
        {
            File = Encoding.UTF8.GetBytes("email,name\na@example.com,A"),
            ColumnMapping = new Dictionary<int, string> { [0] = "email", [1] = "name" }
        });

        Assert.Contains("name=file", body);
        Assert.Contains("filename=subscribers.csv", body);
        Assert.Contains("name=column_mapping", body);
        Assert.Contains("\"0\":\"email\"", body);
    }

    [Fact]
    public async Task HtmlImportSendsHtmlFile()
    {
        string? body = null;
        var handler = new TestHttpMessageHandler(async (request, cancellationToken) =>
        {
            body = await request.Content!.ReadAsStringAsync(cancellationToken);
            return JsonResponse("{\"success\":true}", HttpStatusCode.Created);
        });
        using var http = new HttpClient(handler) { BaseAddress = new Uri("https://posta.example.com") };
        using var client = new PostaClient(http, new FixedCredentialProvider("token"));

        await client.Templates.ImportHtmlTemplateAsync(new ImportHtmlTemplateRequest
        {
            File = Encoding.UTF8.GetBytes("<h1>Hello</h1>"),
            FileName = "hello.html"
        });

        Assert.Contains("filename=hello.html", body);
        Assert.Contains("Content-Type: text/html", body);
    }

    [Fact]
    public void WebhookSignatureUsesPostaHmacFormat()
    {
        const string body = "{\"event\":\"email.sent\"}";
        var digest = HMACSHA256.HashData(Encoding.UTF8.GetBytes("secret"), Encoding.UTF8.GetBytes(body));
        var signature = "sha256=" + Convert.ToHexString(digest).ToLowerInvariant();
        Assert.True(PostaWebhookSignature.Verify(body, "secret", signature));
        Assert.False(PostaWebhookSignature.Verify(body + " ", "secret", signature));
    }

    private static HttpResponseMessage JsonResponse(string json, HttpStatusCode status = HttpStatusCode.OK) => new(status)
    {
        Content = new StringContent(json, Encoding.UTF8, "application/json")
    };

    private sealed class FixedCredentialProvider(string credential) : IPostaCredentialProvider
    {
        public ValueTask<string?> GetCredentialAsync(PostaAuthentication authentication, CancellationToken cancellationToken = default) =>
            ValueTask.FromResult<string?>(credential);
    }
}
