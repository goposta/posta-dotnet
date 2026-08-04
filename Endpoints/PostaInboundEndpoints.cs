namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Inbound API area.</summary>
public interface IPostaInboundEndpoints
{
    /// <summary>Receive inbound email via webhook</summary>
        PostaEndpoint ReceiveInboundEmailViaWebhook { get; }

    /// <summary>List inbound emails</summary>
        PostaEndpoint ListInboundEmails { get; }

    /// <summary>Delete an inbound email</summary>
        PostaEndpoint DeleteAnInboundEmail { get; }

    /// <summary>Get an inbound email by UUID</summary>
        PostaEndpoint GetAnInboundEmailByUuid { get; }

    /// <summary>Download the raw RFC 5322 message (.eml)</summary>
        PostaEndpoint DownloadTheRawRfc5322MessageEml { get; }

    /// <summary>Retry webhook dispatch for a failed inbound email</summary>
        PostaEndpoint RetryWebhookDispatchForAFailedInboundEmail { get; }

    /// <summary>Download an inbound email attachment (authenticated)</summary>
        PostaEndpoint DownloadAnInboundEmailAttachmentAuthenticated { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint ReceiveInboundEmailViaWebhook { get; } = new(HttpMethod.Post, "/api/v1/inbound/webhook", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint ListInboundEmails { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/inbound-emails", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteAnInboundEmail { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/inbound-emails/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetAnInboundEmailByUuid { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/inbound-emails/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DownloadTheRawRfc5322MessageEml { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/inbound-emails/{id}/raw", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RetryWebhookDispatchForAFailedInboundEmail { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/inbound-emails/{id}/retry", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DownloadAnInboundEmailAttachmentAuthenticated { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/inbound-emails/{uuid}/attachments/{idx}", PostaAuthentication.AccessToken);
}
