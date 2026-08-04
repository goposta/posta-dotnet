# Posta .NET SDK

The .NET SDK for [Posta](https://github.com/goposta/posta), the self-hosted email delivery and inbound platform.

## Installation

```shell
dotnet add package Posta
```

## Quick start

```csharp
using Posta.Clients;
using Posta.Models.Emails;

using var client = new PostaClient(
    "https://posta.example.com",
    "your-api-key");

SendAnEmailResponse? response = await client.Emails.SendAnEmailAsync(
    new SendAnEmailRequest
    {
        From = "Acme <hello@example.com>",
        To = ["user@example.com"],
        Subject = "Hello from Posta",
        Html = "<h1>Hello!</h1>"
    });
```

The client exposes concrete, typed API clients such as `Emails`, `Templates`, `Campaigns`, `Subscribers`, `Inbound`, `Webhooks`, `Workspaces`, and `Admin`:

```csharp
PostaEmailsClient emails = client.Emails;
PostaWebhooksClient webhooks = client.Webhooks;
PostaInboundClient inbound = client.Inbound;
PostaAdminClient admin = client.Admin;
```

Each API area has its own concrete client and operations file, so consumers only see the operations that belong to that area. Section client interfaces are intentionally not exposed.

## Known string values

Properties backed by a fixed set of API values remain strings for forward compatibility. The `Posta.Models.Constants` namespace provides constants for discoverability and to avoid string literals:

```csharp
using Posta.Models.Constants;

if (verificationResponse.Data?.Status == EmailVerificationStatuses.Valid)
{
    Console.WriteLine("The email address is valid.");
}
```

The available constant groups are:

- `EmailVerificationStatuses`: `Valid`, `Invalid`, `Risky`, `Disposable`, and `Unknown`
- `UserRoles`: `Admin` and `User`
- `WebhookEvents`: supported email and campaign webhook events
- `SmtpSecurityModes`: `Permissive` and `Strict`
- `ApiKeyScopes`: `Send`, `Read`, `Webhooks`, and `All`
- `BounceTypes`: `Hard` and `Soft`

They can also be used when constructing requests:

```csharp
using Posta.Models.Constants;
using Posta.Models.Webhooks;

var request = new CreateWebhookRequest
{
    Url = "https://example.com/webhooks/posta",
    Events = [WebhookEvents.EmailSent, WebhookEvents.EmailFailed]
};
```

## Configuration

Use `PostaClientSettings` when API-key and JWT credentials, a custom timeout, or late-bound configuration are needed:

```csharp
using Posta.Clients;
using Posta.Configuration;

using var client = new PostaClient(new PostaClientSettings
{
    Endpoint = new Uri("https://posta.example.com"),
    ApiKey = "your-api-key",
    AccessToken = "optional-jwt-access-token",
    Timeout = TimeSpan.FromSeconds(30)
});
```

An application that manages `HttpClient` itself can use the constructor accepting `HttpClient`, `IPostaCredentialProvider`, and an optional custom `IPostaEndpoints` catalog.

## Aspire integration

Install the optional client-integration package in the service that calls Posta:

```shell
dotnet add package Posta.Aspire
```

Register the client using the same resource name passed from the AppHost with `WithReference(...)`:

```csharp
builder.AddPostaClient("posta", settings =>
{
    settings.ApiKey = builder.Configuration["Posta:ApiKey"];
});
```

Resolve the concrete `PostaClient` from dependency injection. `Posta.Aspire` reads the Aspire connection string, configures `HttpClient`, and enables service discovery for the logical `posta` host name.

Multiple Posta resources can be registered with `AddKeyedPostaClient(...)` and resolved through `GetRequiredKeyedService<PostaClient>(key)`.

## Error handling

Non-successful HTTP responses throw `PostaApiException`. The exception contains the HTTP status code and the response body returned by Posta.

```csharp
using Posta.Transport;

try
{
    await client.Emails.GetEmailDetailsAsync(
        new GetEmailDetailsRequest { Id = emailId });
}
catch (PostaApiException exception)
{
    Console.WriteLine(exception.StatusCode);
    Console.WriteLine(exception.ResponseBody);
    Console.WriteLine(exception.Error?.Code);
    Console.WriteLine(exception.Error?.Type);
    Console.WriteLine(exception.Error?.Message);
}
```

When an `ILoggerFactory` is supplied to `PostaClient`, non-successful responses are logged with structured properties. Client errors, including 401, 404, and 429, use `Warning`; 5xx responses use `Error`. Aspire registration uses the application's logger factory automatically. Response bodies are not written to logs.

## Custom endpoints

Endpoint definitions are grouped by API area, including `IPostaEmailsEndpoints`, `IPostaWebhooksEndpoints`, `IPostaInboundEndpoints`, and `IPostaAdminEndpoints`. `IPostaEndpoints` combines these focused endpoint contracts into the complete catalog used by `PostaClient`. The default `PostaEndpoints` implementation is partial, with each API area's virtual properties stored in a matching file.

Deployments with custom routes can continue to override only the required operation:

```csharp
using Posta.Endpoints;

public sealed class CustomPostaEndpoints : PostaEndpoints
{
    public override PostaEndpoint SendAnEmail { get; } =
        new(HttpMethod.Post, "/custom/v1/emails/send", PostaAuthentication.ApiKey);
}
```

## API coverage

The models, endpoints, and operations follow Posta 0.13.1. This includes inbound email management, streaming raw RFC 5322 messages and attachments, CSV subscriber import, HTML template import, update status, and authenticated SMTP-relay related platform APIs.

Multipart imports accept file bytes and construct the required form fields:

```csharp
await client.Subscribers.BulkImportSubscribersCsvAsync(
    new BulkImportSubscribersCsvRequest
    {
        File = await File.ReadAllBytesAsync("subscribers.csv"),
        ColumnMapping = new Dictionary<int, string>
        {
            [0] = "email",
            [1] = "name"
        }
    });
```

Download methods return `PostaStreamResponse`; dispose it after consuming `Stream`. Webhook payload models are in `Posta.Models.Webhooks`, and `Posta.Security.PostaWebhookSignature.Verify(...)` validates `X-Posta-Signature` against the raw request body using HMAC-SHA256.

- [Posta documentation](https://docs.goposta.dev/)
- [Posta API reference](https://app.goposta.dev/docs)
- [Posta OpenAPI document](https://app.goposta.dev/openapi.json)

## Building NuGet packages

On Windows:

```shell
pack-nuget.bat
```

On Linux or macOS:

```shell
bash ./pack-nuget.sh
```

Both scripts create the `Posta` and `Posta.Aspire` packages in the `artifacts` directory.

## Tests

Run the xUnit test suite from the repository root:

```shell
dotnet test Posta.Tests/Posta.Tests.csproj
```

## License

Apache-2.0
