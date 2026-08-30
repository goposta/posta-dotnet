using Posta.Transport;
using Users = Posta.Models.Users;

namespace Posta.Clients;

public sealed partial class PostaUsersClient
{
    /// <summary>Sets the current user's default workspace.</summary>
    public Task<Users.SetDefaultWorkspaceResponse?> SetDefaultWorkspaceAsync(Users.SetDefaultWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.SetDefaultWorkspaceResponse>(_endpoints.SetDefaultWorkspace, new PostaRequest { Body = request }, cancellationToken);
    }

    public Task<Users.RevokeSessionResponse?> RevokeSessionAsync(Users.RevokeSessionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Users.RevokeSessionResponse>(_endpoints.RevokeSession, postaRequest, cancellationToken);
    }
    public Task<Users.ResendVerificationEmailResponse?> ResendVerificationEmailAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.ResendVerificationEmailResponse>(_endpoints.ResendVerificationEmail, null, cancellationToken);
    }
    public Task<Users.RevokeAllOtherSessionsResponse?> RevokeAllOtherSessionsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.RevokeAllOtherSessionsResponse>(_endpoints.RevokeAllOtherSessions, null, cancellationToken);
    }
    public Task<Users.LogoutCurrentSessionResponse?> LogoutCurrentSessionAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.LogoutCurrentSessionResponse>(_endpoints.LogoutCurrentSession, null, cancellationToken);
    }
    public Task<Users.VerifyAndEnable2faResponse?> VerifyAndEnable2faAsync(Users.VerifyAndEnable2faRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.VerifyAndEnable2faResponse>(_endpoints.VerifyAndEnable2fa, postaRequest, cancellationToken);
    }
    public Task<Users.ListActiveSessionsResponse?> ListActiveSessionsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.ListActiveSessionsResponse>(_endpoints.ListActiveSessions, null, cancellationToken);
    }
    public Task<Users.ListUserAuditLogResponse?> ListUserAuditLogAsync(Users.ListUserAuditLogRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["category"] = request?.Category,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Users.ListUserAuditLogResponse>(_endpoints.ListUserAuditLog, postaRequest, cancellationToken);
    }
    public Task<Users.ChangePasswordResponse?> ChangePasswordAsync(Users.ChangePasswordRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.ChangePasswordResponse>(_endpoints.ChangePassword, postaRequest, cancellationToken);
    }
    public Task<Users.Disable2faResponse?> Disable2faAsync(Users.Disable2faRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.Disable2faResponse>(_endpoints.Disable2fa, postaRequest, cancellationToken);
    }
    public Task<Users.RequestAccountDeletionResponse?> RequestAccountDeletionAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.RequestAccountDeletionResponse>(_endpoints.RequestAccountDeletion, null, cancellationToken);
    }
    public Task<Users.CancelAccountDeletionResponse?> CancelAccountDeletionAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.CancelAccountDeletionResponse>(_endpoints.CancelAccountDeletion, null, cancellationToken);
    }
    public Task<Users.UpdateUserSettingsResponse?> UpdateUserSettingsAsync(Users.UpdateUserSettingsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.UpdateUserSettingsResponse>(_endpoints.UpdateUserSettings, postaRequest, cancellationToken);
    }
    public Task<Users.UpdateProfileResponse?> UpdateProfileAsync(Users.UpdateProfileRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.UpdateProfileResponse>(_endpoints.UpdateProfile, postaRequest, cancellationToken);
    }
    public Task<Users.GetMyPlanResponse?> GetMyPlanAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.GetMyPlanResponse>(_endpoints.GetMyPlan, null, cancellationToken);
    }
    public Task<Users.Setup2faResponse?> Setup2faAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.Setup2faResponse>(_endpoints.Setup2fa, null, cancellationToken);
    }
    public Task<Users.GetCurrentUserProfileResponse?> GetCurrentUserProfileAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.GetCurrentUserProfileResponse>(_endpoints.GetCurrentUserProfile, null, cancellationToken);
    }
    public Task<Users.GetUserSettingsResponse?> GetUserSettingsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.GetUserSettingsResponse>(_endpoints.GetUserSettings, null, cancellationToken);
    }
}



