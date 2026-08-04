namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the WorkspaceResources API area.</summary>
public interface IPostaWorkspaceResourcesEndpoints
{
    /// <summary>Email analytics</summary>
        PostaEndpoint EmailAnalytics { get; }

    /// <summary>Dashboard analytics</summary>
        PostaEndpoint DashboardAnalytics { get; }

    /// <summary>Deliverability by provider</summary>
        PostaEndpoint DeliverabilityByProvider { get; }

    /// <summary>List API keys</summary>
        PostaEndpoint ListApiKeys { get; }

    /// <summary>Create API key</summary>
        PostaEndpoint CreateApiKey { get; }

    /// <summary>Delete API key</summary>
        PostaEndpoint DeleteApiKey { get; }

    /// <summary>Get API key</summary>
        PostaEndpoint GetApiKey { get; }

    /// <summary>Revoke API key</summary>
        PostaEndpoint RevokeApiKey { get; }

    /// <summary>List bounces</summary>
        PostaEndpoint ListBouncesWorkspaceResources { get; }

    /// <summary>Record a bounce</summary>
        PostaEndpoint RecordABounce { get; }

    /// <summary>List contacts</summary>
        PostaEndpoint ListContacts { get; }

    /// <summary>Get contact details</summary>
        PostaEndpoint GetContactDetails { get; }

    /// <summary>Get dashboard statistics</summary>
        PostaEndpoint GetDashboardStatistics { get; }

    /// <summary>List domains</summary>
        PostaEndpoint ListDomains { get; }

    /// <summary>Add domain</summary>
        PostaEndpoint AddDomain { get; }

    /// <summary>Delete domain</summary>
        PostaEndpoint DeleteDomain { get; }

    /// <summary>Get domain details</summary>
        PostaEndpoint GetDomainDetails { get; }

    /// <summary>Verify domain DNS records</summary>
        PostaEndpoint VerifyDomainDnsRecords { get; }

    /// <summary>List languages</summary>
        PostaEndpoint ListLanguages { get; }

    /// <summary>Create language</summary>
        PostaEndpoint CreateLanguage { get; }

    /// <summary>Delete language</summary>
        PostaEndpoint DeleteLanguage { get; }

    /// <summary>Update language</summary>
        PostaEndpoint UpdateLanguage { get; }

    /// <summary>List SMTP servers</summary>
        PostaEndpoint ListSmtpServers { get; }

    /// <summary>Add SMTP server</summary>
        PostaEndpoint AddSmtpServer { get; }

    /// <summary>Delete SMTP server</summary>
        PostaEndpoint DeleteSmtpServer { get; }

    /// <summary>Get SMTP server</summary>
        PostaEndpoint GetSmtpServer { get; }

    /// <summary>Update SMTP server</summary>
        PostaEndpoint UpdateSmtpServer { get; }

    /// <summary>Test SMTP server connection</summary>
        PostaEndpoint TestSmtpServerConnection { get; }

    /// <summary>Remove from suppression list</summary>
        PostaEndpoint RemoveFromSuppressionList { get; }

    /// <summary>List suppressed emails</summary>
        PostaEndpoint ListSuppressedEmails { get; }

    /// <summary>Add to suppression list</summary>
        PostaEndpoint AddToSuppressionList { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint EmailAnalytics { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/analytics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DashboardAnalytics { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/analytics/dashboard", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeliverabilityByProvider { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/analytics/providers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListApiKeys { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/api-keys", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateApiKey { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/api-keys", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteApiKey { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/api-keys/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetApiKey { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/api-keys/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RevokeApiKey { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/api-keys/{id}/revoke", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListBouncesWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/bounces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RecordABounce { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/bounces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListContacts { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/contacts", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetContactDetails { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/contacts/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetDashboardStatistics { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/dashboard/stats", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListDomains { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/domains", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint AddDomain { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/domains", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteDomain { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/domains/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetDomainDetails { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/domains/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint VerifyDomainDnsRecords { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/domains/{id}/verify", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListLanguages { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/languages", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateLanguage { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/languages", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteLanguage { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/languages/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateLanguage { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/languages/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListSmtpServers { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/smtp-servers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint AddSmtpServer { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/smtp-servers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteSmtpServer { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/smtp-servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetSmtpServer { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/smtp-servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateSmtpServer { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/smtp-servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint TestSmtpServerConnection { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/smtp-servers/{id}/test", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RemoveFromSuppressionList { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/suppressions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListSuppressedEmails { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/suppressions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint AddToSuppressionList { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/suppressions", PostaAuthentication.AccessToken);
}
