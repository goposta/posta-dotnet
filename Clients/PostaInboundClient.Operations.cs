using Posta.Transport;
using Inbound = Posta.Models.Inbound;

namespace Posta.Clients;

public sealed partial class PostaInboundClient
{
    public Task<Inbound.DeleteAnInboundEmailResponse?> DeleteAnInboundEmailAsync(Inbound.DeleteAnInboundEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Inbound.DeleteAnInboundEmailResponse>(_endpoints.DeleteAnInboundEmail, postaRequest, cancellationToken);
    }
    public Task<PostaStreamResponse> DownloadAnInboundEmailAttachmentAuthenticatedAsync(Inbound.DownloadAnInboundEmailAttachmentAuthenticatedRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["uuid"] = request?.Uuid,
                ["idx"] = request?.Idx,
            },
        };

        return SendStreamAsync(_endpoints.DownloadAnInboundEmailAttachmentAuthenticated, postaRequest, cancellationToken);
    }
    public Task<Inbound.GetAnInboundEmailByUuidResponse?> GetAnInboundEmailByUuidAsync(Inbound.GetAnInboundEmailByUuidRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Inbound.GetAnInboundEmailByUuidResponse>(_endpoints.GetAnInboundEmailByUuid, postaRequest, cancellationToken);
    }
    public Task<Inbound.ReceiveInboundEmailViaWebhookResponse?> ReceiveInboundEmailViaWebhookAsync(Inbound.ReceiveInboundEmailViaWebhookRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Inbound-Secret"] = Convert.ToString(request?.XPostaInboundSecret, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Inbound.ReceiveInboundEmailViaWebhookResponse>(_endpoints.ReceiveInboundEmailViaWebhook, postaRequest, cancellationToken);
    }
    public Task<Inbound.ListInboundEmailsResponse?> ListInboundEmailsAsync(Inbound.ListInboundEmailsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["status"] = request?.Status,
                ["source"] = request?.Source,
                ["sender"] = request?.Sender,
                ["q"] = request?.Q,
            },
        };

        return SendAsync<Inbound.ListInboundEmailsResponse>(_endpoints.ListInboundEmails, postaRequest, cancellationToken);
    }
    public Task<Inbound.RetryWebhookDispatchForAFailedInboundEmailResponse?> RetryWebhookDispatchForAFailedInboundEmailAsync(Inbound.RetryWebhookDispatchForAFailedInboundEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Inbound.RetryWebhookDispatchForAFailedInboundEmailResponse>(_endpoints.RetryWebhookDispatchForAFailedInboundEmail, postaRequest, cancellationToken);
    }
    public Task<PostaStreamResponse> DownloadTheRawRfc5322MessageEmlAsync(Inbound.DownloadTheRawRfc5322MessageEmlRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendStreamAsync(_endpoints.DownloadTheRawRfc5322MessageEml, postaRequest, cancellationToken);
    }
}




