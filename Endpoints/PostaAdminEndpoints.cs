namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Admin API area.</summary>
public interface IPostaAdminEndpoints
{
    /// <summary>Platform analytics</summary>
        PostaEndpoint PlatformAnalytics { get; }

    /// <summary>Platform dashboard analytics</summary>
        PostaEndpoint PlatformDashboardAnalytics { get; }

    /// <summary>Platform deliverability by provider</summary>
        PostaEndpoint PlatformDeliverabilityByProvider { get; }

    /// <summary>List events</summary>
        PostaEndpoint ListEvents { get; }

    /// <summary>Get event</summary>
        PostaEndpoint GetEvent { get; }

    /// <summary>List scheduled jobs</summary>
        PostaEndpoint ListScheduledJobs { get; }

    /// <summary>Platform metrics</summary>
        PostaEndpoint PlatformMetrics { get; }

    /// <summary>List all OAuth providers (admin)</summary>
        PostaEndpoint ListAllOauthProvidersAdmin { get; }

    /// <summary>Create OAuth provider</summary>
        PostaEndpoint CreateOauthProvider { get; }

    /// <summary>Delete OAuth provider</summary>
        PostaEndpoint DeleteOauthProvider { get; }

    /// <summary>Update OAuth provider</summary>
        PostaEndpoint UpdateOauthProvider { get; }

    /// <summary>List plans</summary>
        PostaEndpoint ListPlans { get; }

    /// <summary>Create plan</summary>
        PostaEndpoint CreatePlan { get; }

    /// <summary>Delete plan</summary>
        PostaEndpoint DeletePlan { get; }

    /// <summary>Get plan</summary>
        PostaEndpoint GetPlan { get; }

    /// <summary>Update plan</summary>
        PostaEndpoint UpdatePlan { get; }

    /// <summary>Set plan as default</summary>
        PostaEndpoint SetPlanAsDefault { get; }

    /// <summary>List shared SMTP servers</summary>
        PostaEndpoint ListSharedSmtpServers { get; }

    /// <summary>Create shared SMTP server</summary>
        PostaEndpoint CreateSharedSmtpServer { get; }

    /// <summary>Delete shared SMTP server</summary>
        PostaEndpoint DeleteSharedSmtpServer { get; }

    /// <summary>Get shared SMTP server</summary>
        PostaEndpoint GetSharedSmtpServer { get; }

    /// <summary>Update shared SMTP server</summary>
        PostaEndpoint UpdateSharedSmtpServer { get; }

    /// <summary>Disable shared SMTP server</summary>
        PostaEndpoint DisableSharedSmtpServer { get; }

    /// <summary>Enable shared SMTP server</summary>
        PostaEndpoint EnableSharedSmtpServer { get; }

    /// <summary>Test shared SMTP server connection</summary>
        PostaEndpoint TestSharedSmtpServerConnection { get; }

    /// <summary>Get platform settings</summary>
        PostaEndpoint GetPlatformSettings { get; }

    /// <summary>Update platform settings</summary>
        PostaEndpoint UpdatePlatformSettings { get; }

    /// <summary>Get update status</summary>
        PostaEndpoint GetUpdateStatus { get; }

    /// <summary>Dismiss an update notice</summary>
        PostaEndpoint DismissUpdateNotice { get; }

    /// <summary>List all users</summary>
        PostaEndpoint ListAllUsers { get; }

    /// <summary>Create a new user</summary>
        PostaEndpoint CreateANewUser { get; }

    /// <summary>Delete user</summary>
        PostaEndpoint DeleteUser { get; }

    /// <summary>Update user</summary>
        PostaEndpoint UpdateUser { get; }

    /// <summary>Disable 2FA for user</summary>
        PostaEndpoint Disable2faForUser { get; }

    /// <summary>Cancel user deletion</summary>
        PostaEndpoint CancelUserDeletion { get; }

    /// <summary>Force delete user</summary>
        PostaEndpoint ForceDeleteUser { get; }

    /// <summary>Get user metrics</summary>
        PostaEndpoint GetUserMetrics { get; }

    /// <summary>Get user plan</summary>
        PostaEndpoint GetUserPlan { get; }

    /// <summary>Assign plan to user</summary>
        PostaEndpoint AssignPlanToUser { get; }

    /// <summary>Revoke all user sessions</summary>
        PostaEndpoint RevokeAllUserSessions { get; }

    /// <summary>List user workspaces</summary>
        PostaEndpoint ListUserWorkspaces { get; }

    /// <summary>Get workspace plan</summary>
        PostaEndpoint GetWorkspacePlan { get; }

    /// <summary>Assign plan to workspace</summary>
        PostaEndpoint AssignPlanToWorkspace { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint PlatformAnalytics { get; } = new(HttpMethod.Get, "/api/v1/admin/analytics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint PlatformDashboardAnalytics { get; } = new(HttpMethod.Get, "/api/v1/admin/analytics/dashboard", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint PlatformDeliverabilityByProvider { get; } = new(HttpMethod.Get, "/api/v1/admin/analytics/providers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListEvents { get; } = new(HttpMethod.Get, "/api/v1/admin/events", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetEvent { get; } = new(HttpMethod.Get, "/api/v1/admin/events/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListScheduledJobs { get; } = new(HttpMethod.Get, "/api/v1/admin/jobs", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint PlatformMetrics { get; } = new(HttpMethod.Get, "/api/v1/admin/metrics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListAllOauthProvidersAdmin { get; } = new(HttpMethod.Get, "/api/v1/admin/oauth/providers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateOauthProvider { get; } = new(HttpMethod.Post, "/api/v1/admin/oauth/providers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteOauthProvider { get; } = new(HttpMethod.Delete, "/api/v1/admin/oauth/providers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateOauthProvider { get; } = new(HttpMethod.Put, "/api/v1/admin/oauth/providers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListPlans { get; } = new(HttpMethod.Get, "/api/v1/admin/plans", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreatePlan { get; } = new(HttpMethod.Post, "/api/v1/admin/plans", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeletePlan { get; } = new(HttpMethod.Delete, "/api/v1/admin/plans/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetPlan { get; } = new(HttpMethod.Get, "/api/v1/admin/plans/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdatePlan { get; } = new(HttpMethod.Put, "/api/v1/admin/plans/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint SetPlanAsDefault { get; } = new(HttpMethod.Patch, "/api/v1/admin/plans/{id}/default", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListSharedSmtpServers { get; } = new(HttpMethod.Get, "/api/v1/admin/servers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateSharedSmtpServer { get; } = new(HttpMethod.Post, "/api/v1/admin/servers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteSharedSmtpServer { get; } = new(HttpMethod.Delete, "/api/v1/admin/servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetSharedSmtpServer { get; } = new(HttpMethod.Get, "/api/v1/admin/servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateSharedSmtpServer { get; } = new(HttpMethod.Put, "/api/v1/admin/servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DisableSharedSmtpServer { get; } = new(HttpMethod.Post, "/api/v1/admin/servers/{id}/disable", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint EnableSharedSmtpServer { get; } = new(HttpMethod.Post, "/api/v1/admin/servers/{id}/enable", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint TestSharedSmtpServerConnection { get; } = new(HttpMethod.Post, "/api/v1/admin/servers/{id}/test", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetPlatformSettings { get; } = new(HttpMethod.Get, "/api/v1/admin/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdatePlatformSettings { get; } = new(HttpMethod.Put, "/api/v1/admin/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetUpdateStatus { get; } = new(HttpMethod.Get, "/api/v1/admin/update", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DismissUpdateNotice { get; } = new(HttpMethod.Post, "/api/v1/admin/update/dismiss", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListAllUsers { get; } = new(HttpMethod.Get, "/api/v1/admin/users", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateANewUser { get; } = new(HttpMethod.Post, "/api/v1/admin/users", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteUser { get; } = new(HttpMethod.Delete, "/api/v1/admin/users/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateUser { get; } = new(HttpMethod.Put, "/api/v1/admin/users/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint Disable2faForUser { get; } = new(HttpMethod.Delete, "/api/v1/admin/users/{id}/2fa", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CancelUserDeletion { get; } = new(HttpMethod.Post, "/api/v1/admin/users/{id}/cancel-deletion", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ForceDeleteUser { get; } = new(HttpMethod.Delete, "/api/v1/admin/users/{id}/force", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetUserMetrics { get; } = new(HttpMethod.Get, "/api/v1/admin/users/{id}/metrics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetUserPlan { get; } = new(HttpMethod.Get, "/api/v1/admin/users/{id}/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint AssignPlanToUser { get; } = new(HttpMethod.Post, "/api/v1/admin/users/{id}/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RevokeAllUserSessions { get; } = new(HttpMethod.Post, "/api/v1/admin/users/{id}/revoke-sessions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListUserWorkspaces { get; } = new(HttpMethod.Get, "/api/v1/admin/users/{id}/workspaces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetWorkspacePlan { get; } = new(HttpMethod.Get, "/api/v1/admin/workspaces/{id}/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint AssignPlanToWorkspace { get; } = new(HttpMethod.Post, "/api/v1/admin/workspaces/{id}/plan", PostaAuthentication.AccessToken);
}
