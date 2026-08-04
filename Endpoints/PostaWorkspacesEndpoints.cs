namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Workspaces API area.</summary>
public interface IPostaWorkspacesEndpoints
{
    /// <summary>My pending invitations</summary>
        PostaEndpoint MyPendingInvitations { get; }

    /// <summary>Accept invitation</summary>
        PostaEndpoint AcceptInvitation { get; }

    /// <summary>Decline invitation by token</summary>
        PostaEndpoint DeclineInvitationByToken { get; }

    /// <summary>Accept invitation by ID</summary>
        PostaEndpoint AcceptInvitationById { get; }

    /// <summary>Decline invitation by ID</summary>
        PostaEndpoint DeclineInvitationById { get; }

    /// <summary>List workspaces</summary>
        PostaEndpoint ListWorkspaces { get; }

    /// <summary>Create workspace</summary>
        PostaEndpoint CreateWorkspace { get; }

    /// <summary>Delete workspace</summary>
        PostaEndpoint DeleteWorkspace { get; }

    /// <summary>Get current workspace</summary>
        PostaEndpoint GetCurrentWorkspace { get; }

    /// <summary>Update workspace</summary>
        PostaEndpoint UpdateWorkspace { get; }

    /// <summary>List workspace audit log</summary>
        PostaEndpoint ListWorkspaceAuditLog { get; }

    /// <summary>Get workspace audit event</summary>
        PostaEndpoint GetWorkspaceAuditEvent { get; }

    /// <summary>Export workspace data</summary>
        PostaEndpoint ExportWorkspaceData { get; }

    /// <summary>Import workspace data</summary>
        PostaEndpoint ImportWorkspaceData { get; }

    /// <summary>Delete workspace contact data (GDPR)</summary>
        PostaEndpoint DeleteWorkspaceContactDataGdpr { get; }

    /// <summary>Delete workspace email logs (GDPR)</summary>
        PostaEndpoint DeleteWorkspaceEmailLogsGdpr { get; }

    /// <summary>List pending invitations</summary>
        PostaEndpoint ListPendingInvitations { get; }

    /// <summary>Invite member</summary>
        PostaEndpoint InviteMember { get; }

    /// <summary>Cancel invitation</summary>
        PostaEndpoint CancelInvitation { get; }

    /// <summary>List workspace members</summary>
        PostaEndpoint ListWorkspaceMembers { get; }

    /// <summary>Remove member</summary>
        PostaEndpoint RemoveMember { get; }

    /// <summary>Update member role</summary>
        PostaEndpoint UpdateMemberRole { get; }

    /// <summary>Get workspace plan</summary>
        PostaEndpoint GetWorkspacePlanWorkspaces { get; }

    /// <summary>Get workspace settings</summary>
        PostaEndpoint GetWorkspaceSettings { get; }

    /// <summary>Update workspace settings</summary>
        PostaEndpoint UpdateWorkspaceSettings { get; }

    /// <summary>Delete workspace SSO config</summary>
        PostaEndpoint DeleteWorkspaceSsoConfig { get; }

    /// <summary>Get workspace SSO config</summary>
        PostaEndpoint GetWorkspaceSsoConfig { get; }

    /// <summary>Set workspace SSO config</summary>
        PostaEndpoint SetWorkspaceSsoConfig { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint MyPendingInvitations { get; } = new(HttpMethod.Get, "/api/v1/invitations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint AcceptInvitation { get; } = new(HttpMethod.Post, "/api/v1/invitations/accept", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeclineInvitationByToken { get; } = new(HttpMethod.Post, "/api/v1/invitations/decline", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint AcceptInvitationById { get; } = new(HttpMethod.Post, "/api/v1/invitations/{id}/accept", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeclineInvitationById { get; } = new(HttpMethod.Post, "/api/v1/invitations/{id}/decline", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListWorkspaces { get; } = new(HttpMethod.Get, "/api/v1/workspaces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateWorkspace { get; } = new(HttpMethod.Post, "/api/v1/workspaces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteWorkspace { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetCurrentWorkspace { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateWorkspace { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListWorkspaceAuditLog { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/audit-log", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetWorkspaceAuditEvent { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/audit-log/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ExportWorkspaceData { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/data/export", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ImportWorkspaceData { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/data/import", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteWorkspaceContactDataGdpr { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/gdpr/delete-contacts", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteWorkspaceEmailLogsGdpr { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/gdpr/delete-email-logs", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListPendingInvitations { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/invitations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint InviteMember { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/invitations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CancelInvitation { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/invitations/{invitation_id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListWorkspaceMembers { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/members", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RemoveMember { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/members/{member_id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateMemberRole { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/members/{member_id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetWorkspacePlanWorkspaces { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetWorkspaceSettings { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateWorkspaceSettings { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteWorkspaceSsoConfig { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/sso", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetWorkspaceSsoConfig { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/sso", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint SetWorkspaceSsoConfig { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/sso", PostaAuthentication.AccessToken);
}
