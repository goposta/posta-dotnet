namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Users API area.</summary>
public interface IPostaUsersEndpoints
{
    /// <summary>Get current user profile</summary>
        PostaEndpoint GetCurrentUserProfile { get; }

    /// <summary>Update profile</summary>
        PostaEndpoint UpdateProfile { get; }

    /// <summary>Disable 2FA</summary>
        PostaEndpoint Disable2fa { get; }

    /// <summary>Setup 2FA</summary>
        PostaEndpoint Setup2fa { get; }

    /// <summary>Verify and enable 2FA</summary>
        PostaEndpoint VerifyAndEnable2fa { get; }

    /// <summary>List user audit log</summary>
        PostaEndpoint ListUserAuditLog { get; }

    /// <summary>Cancel account deletion</summary>
        PostaEndpoint CancelAccountDeletion { get; }

    /// <summary>Request account deletion</summary>
        PostaEndpoint RequestAccountDeletion { get; }

    /// <summary>Change password</summary>
        PostaEndpoint ChangePassword { get; }

    /// <summary>Get my plan</summary>
        PostaEndpoint GetMyPlan { get; }

    /// <summary>List active sessions</summary>
        PostaEndpoint ListActiveSessions { get; }

    /// <summary>Logout current session</summary>
        PostaEndpoint LogoutCurrentSession { get; }

    /// <summary>Revoke all other sessions</summary>
        PostaEndpoint RevokeAllOtherSessions { get; }

    /// <summary>Revoke session</summary>
        PostaEndpoint RevokeSession { get; }

    /// <summary>Get user settings</summary>
        PostaEndpoint GetUserSettings { get; }

    /// <summary>Update user settings</summary>
        PostaEndpoint UpdateUserSettings { get; }

    /// <summary>Resend verification email</summary>
        PostaEndpoint ResendVerificationEmail { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint GetCurrentUserProfile { get; } = new(HttpMethod.Get, "/api/v1/users/me", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateProfile { get; } = new(HttpMethod.Put, "/api/v1/users/me", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint Disable2fa { get; } = new(HttpMethod.Post, "/api/v1/users/me/2fa/disable", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint Setup2fa { get; } = new(HttpMethod.Post, "/api/v1/users/me/2fa/setup", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint VerifyAndEnable2fa { get; } = new(HttpMethod.Post, "/api/v1/users/me/2fa/verify", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListUserAuditLog { get; } = new(HttpMethod.Get, "/api/v1/users/me/audit-log", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CancelAccountDeletion { get; } = new(HttpMethod.Post, "/api/v1/users/me/cancel-deletion", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RequestAccountDeletion { get; } = new(HttpMethod.Post, "/api/v1/users/me/delete", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ChangePassword { get; } = new(HttpMethod.Put, "/api/v1/users/me/password", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetMyPlan { get; } = new(HttpMethod.Get, "/api/v1/users/me/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListActiveSessions { get; } = new(HttpMethod.Get, "/api/v1/users/me/sessions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint LogoutCurrentSession { get; } = new(HttpMethod.Post, "/api/v1/users/me/sessions/logout", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RevokeAllOtherSessions { get; } = new(HttpMethod.Post, "/api/v1/users/me/sessions/revoke-others", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RevokeSession { get; } = new(HttpMethod.Delete, "/api/v1/users/me/sessions/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetUserSettings { get; } = new(HttpMethod.Get, "/api/v1/users/me/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateUserSettings { get; } = new(HttpMethod.Put, "/api/v1/users/me/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ResendVerificationEmail { get; } = new(HttpMethod.Post, "/api/v1/users/me/verify-email/resend", PostaAuthentication.AccessToken);
}
