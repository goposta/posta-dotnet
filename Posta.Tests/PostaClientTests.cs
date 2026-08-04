using System.Net;
using Posta.Clients;
using Posta.Configuration;
using Posta.Endpoints;
using Posta.Models.Constants;
using Posta.Models.Emails;
using Posta.Models.Admin;

namespace Posta.Tests;

public sealed class PostaClientTests
{
    [Fact]
    public void SettingsConstructorRequiresEndpoint()
    {
        var exception = Assert.Throws<ArgumentException>(() => new PostaClient(new PostaClientSettings()));

        Assert.Equal("settings", exception.ParamName);
    }

    [Fact]
    public void ExternalHttpClientRequiresBaseAddress()
    {
        using var httpClient = new HttpClient();

        var exception = Assert.Throws<ArgumentException>(
            () => new PostaClient(httpClient, new FixedCredentialProvider("secret")));

        Assert.Equal("httpClient", exception.ParamName);
    }

    [Fact]
    public void ApiSectionsAreIndependentConcreteClients()
    {
        using var client = new PostaClient("https://posta.example.com", "secret");

        Assert.IsType<PostaEmailsClient>(client.Emails);
        Assert.IsType<PostaHealthClient>(client.Health);
        Assert.IsType<PostaWebhooksClient>(client.Webhooks);
        Assert.IsType<PostaWorkspacesClient>(client.Workspaces);
    }

    [Fact]
    public async Task VerifyEmailSendsApiKeyAndDeserializesResponse()
    {
        Uri? requestUri = null;
        string? authorizationScheme = null;
        string? authorizationValue = null;
        string? requestBody = null;
        var handler = new TestHttpMessageHandler(async (request, cancellationToken) =>
        {
            requestUri = request.RequestUri;
            authorizationScheme = request.Headers.Authorization?.Scheme;
            authorizationValue = request.Headers.Authorization?.Parameter;
            requestBody = await request.Content!.ReadAsStringAsync(cancellationToken);

            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""
                    {
                      "data": {
                        "cached": true,
                        "checked_at": "2026-07-13T13:01:58.304Z",
                        "email": "user@example.com",
                        "score": 1,
                        "status": "valid"
                      },
                      "success": true
                    }
                    """, System.Text.Encoding.UTF8, "application/json")
            };
        });
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://posta.example.com")
        };
        using var client = new PostaClient(httpClient, new FixedCredentialProvider("api-key"));

        var response = await client.Emails.VerifyAnEmailAddressAsync(
            new VerifyAnEmailAddressRequest
            {
                Email = "user@example.com",
                Fresh = true
            });

        Assert.Equal("https://posta.example.com/api/v1/emails/verify?fresh=true", requestUri?.AbsoluteUri);
        Assert.Equal("Bearer", authorizationScheme);
        Assert.Equal("api-key", authorizationValue);
        Assert.Equal("{\"email\":\"user@example.com\"}", requestBody);
        Assert.True(response?.Success);
        Assert.Equal(EmailVerificationStatuses.Valid, response?.Data?.Status);
        Assert.Equal("user@example.com", response?.Data?.Email);
        Assert.Equal(DateTimeOffset.Parse("2026-07-13T13:01:58.304Z"), response?.Data?.CheckedAt);
    }

    [Fact]
    public async Task HealthProbeDoesNotSendAuthorizationHeader()
    {
        var hasAuthorization = true;
        var handler = new TestHttpMessageHandler((request, _) =>
        {
            hasAuthorization = request.Headers.Authorization is not null;
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{\"status\":\"ok\"}", System.Text.Encoding.UTF8, "application/json")
            });
        });
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://posta.example.com")
        };
        using var client = new PostaClient(httpClient, new FixedCredentialProvider("unused"));

        var response = await client.Health.LivenessProbeAsync();

        Assert.False(hasAuthorization);
        Assert.Equal("ok", response?.Status);
    }

    [Fact]
    public async Task GetUpdateStatusUsesAdminEndpointAndDeserializesResponse()
    {
        Uri? requestUri = null;
        var handler = new TestHttpMessageHandler((request, _) =>
        {
            requestUri = request.RequestUri;
            return Task.FromResult(new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""
                    {
                      "data": {
                        "current_version": "v0.12.0",
                        "latest_version": "v0.13.0",
                        "release_url": "https://github.com/goposta/posta/releases/tag/v0.13.0",
                        "published_at": "2026-07-22T18:53:25Z",
                        "update_available": true,
                        "enabled": true,
                        "checked_at": "2026-07-23T03:00:00Z",
                        "last_error": ""
                      },
                      "success": true
                    }
                    """, System.Text.Encoding.UTF8, "application/json")
            });
        });
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://posta.example.com")
        };
        using var client = new PostaClient(httpClient, new FixedCredentialProvider("access-token"));

        var response = await client.Admin.GetUpdateStatusAsync();

        Assert.Equal("https://posta.example.com/api/v1/admin/update", requestUri?.AbsoluteUri);
        Assert.True(response?.Success);
        Assert.Equal("v0.13.0", response?.Data?.LatestVersion);
        Assert.True(response?.Data?.UpdateAvailable);
        Assert.Equal(DateTimeOffset.Parse("2026-07-22T18:53:25Z"), response?.Data?.PublishedAt);
    }

    [Fact]
    public async Task DismissUpdateNoticePostsVersion()
    {
        Uri? requestUri = null;
        string? requestBody = null;
        var handler = new TestHttpMessageHandler(async (request, cancellationToken) =>
        {
            requestUri = request.RequestUri;
            requestBody = await request.Content!.ReadAsStringAsync(cancellationToken);
            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("""
                    {"data":{"message":"update notice dismissed"},"success":true}
                    """, System.Text.Encoding.UTF8, "application/json")
            };
        });
        using var httpClient = new HttpClient(handler)
        {
            BaseAddress = new Uri("https://posta.example.com")
        };
        using var client = new PostaClient(httpClient, new FixedCredentialProvider("access-token"));

        var response = await client.Admin.DismissUpdateNoticeAsync(
            new DismissUpdateNoticeRequest { Version = "v0.13.0" });

        Assert.Equal("https://posta.example.com/api/v1/admin/update/dismiss", requestUri?.AbsoluteUri);
        Assert.Equal("{\"version\":\"v0.13.0\"}", requestBody);
        Assert.True(response?.Success);
        Assert.Equal("update notice dismissed", response?.Data?.Message);
    }

    private sealed class FixedCredentialProvider(string? credential) : IPostaCredentialProvider
    {
        public ValueTask<string?> GetCredentialAsync(
            PostaAuthentication authentication,
            CancellationToken cancellationToken = default) => ValueTask.FromResult(credential);
    }
}
