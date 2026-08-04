namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Emails API area.</summary>
public interface IPostaEmailsEndpoints
{
    /// <summary>List bounces</summary>
        PostaEndpoint ListBounces { get; }

    /// <summary>List emails</summary>
        PostaEndpoint ListEmails { get; }

    /// <summary>Send batch emails</summary>
        PostaEndpoint SendBatchEmails { get; }

    /// <summary>Preview email from template</summary>
        PostaEndpoint PreviewEmailFromTemplate { get; }

    /// <summary>Send an email</summary>
        PostaEndpoint SendAnEmail { get; }

    /// <summary>Send email using template</summary>
        PostaEndpoint SendEmailUsingTemplate { get; }

    /// <summary>Verify an email address</summary>
        PostaEndpoint VerifyAnEmailAddress { get; }

    /// <summary>Get email details</summary>
        PostaEndpoint GetEmailDetails { get; }

    /// <summary>Retry failed email</summary>
        PostaEndpoint RetryFailedEmail { get; }

    /// <summary>Get email delivery status</summary>
        PostaEndpoint GetEmailDeliveryStatus { get; }

    /// <summary>List emails</summary>
        PostaEndpoint ListEmailsWorkspaceResources { get; }

    /// <summary>Preview email from template</summary>
        PostaEndpoint PreviewEmailFromTemplateWorkspaceResources { get; }

    /// <summary>Get email details</summary>
        PostaEndpoint GetEmailDetailsWorkspaceResources { get; }

    /// <summary>Retry failed email</summary>
        PostaEndpoint RetryFailedEmailWorkspaceResources { get; }

    /// <summary>Get email delivery status</summary>
        PostaEndpoint GetEmailDeliveryStatusWorkspaceResources { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint ListBounces { get; } = new(HttpMethod.Get, "/api/v1/bounces", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint ListEmails { get; } = new(HttpMethod.Get, "/api/v1/emails", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint SendBatchEmails { get; } = new(HttpMethod.Post, "/api/v1/emails/batch", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint PreviewEmailFromTemplate { get; } = new(HttpMethod.Post, "/api/v1/emails/preview", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint SendAnEmail { get; } = new(HttpMethod.Post, "/api/v1/emails/send", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint SendEmailUsingTemplate { get; } = new(HttpMethod.Post, "/api/v1/emails/send-template", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint VerifyAnEmailAddress { get; } = new(HttpMethod.Post, "/api/v1/emails/verify", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint GetEmailDetails { get; } = new(HttpMethod.Get, "/api/v1/emails/{id}", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint RetryFailedEmail { get; } = new(HttpMethod.Post, "/api/v1/emails/{id}/retry", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint GetEmailDeliveryStatus { get; } = new(HttpMethod.Get, "/api/v1/emails/{id}/status", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint ListEmailsWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/emails", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint PreviewEmailFromTemplateWorkspaceResources { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/emails/preview", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetEmailDetailsWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/emails/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RetryFailedEmailWorkspaceResources { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/emails/{id}/retry", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetEmailDeliveryStatusWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/emails/{id}/status", PostaAuthentication.AccessToken);
}
