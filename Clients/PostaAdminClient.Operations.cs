using Posta.Transport;
using Admin = Posta.Models.Admin;

namespace Posta.Clients;

public sealed partial class PostaAdminClient
{
    public Task<Admin.DismissUpdateNoticeResponse?> DismissUpdateNoticeAsync(Admin.DismissUpdateNoticeRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.DismissUpdateNoticeResponse>(_endpoints.DismissUpdateNotice, postaRequest, cancellationToken);
    }
    public Task<Admin.UpdatePlatformSettingsResponse?> UpdatePlatformSettingsAsync(Admin.UpdatePlatformSettingsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.UpdatePlatformSettingsResponse>(_endpoints.UpdatePlatformSettings, postaRequest, cancellationToken);
    }
    public Task<Admin.AssignPlanToWorkspaceResponse?> AssignPlanToWorkspaceAsync(Admin.AssignPlanToWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.AssignPlanToWorkspaceResponse>(_endpoints.AssignPlanToWorkspace, postaRequest, cancellationToken);
    }
    public Task<Admin.PlatformDashboardAnalyticsResponse?> PlatformDashboardAnalyticsAsync(Admin.PlatformDashboardAnalyticsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
            },
        };

        return SendAsync<Admin.PlatformDashboardAnalyticsResponse>(_endpoints.PlatformDashboardAnalytics, postaRequest, cancellationToken);
    }
    public Task<Admin.GetUserPlanResponse?> GetUserPlanAsync(Admin.GetUserPlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetUserPlanResponse>(_endpoints.GetUserPlan, postaRequest, cancellationToken);
    }
    public Task<Admin.ListAllUsersResponse?> ListAllUsersAsync(Admin.ListAllUsersRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Admin.ListAllUsersResponse>(_endpoints.ListAllUsers, postaRequest, cancellationToken);
    }
    public Task<Admin.PlatformAnalyticsResponse?> PlatformAnalyticsAsync(Admin.PlatformAnalyticsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<Admin.PlatformAnalyticsResponse>(_endpoints.PlatformAnalytics, postaRequest, cancellationToken);
    }
    public Task<Admin.CreateOauthProviderResponse?> CreateOauthProviderAsync(Admin.CreateOauthProviderRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.CreateOauthProviderResponse>(_endpoints.CreateOauthProvider, postaRequest, cancellationToken);
    }
    public Task<Admin.GetPlatformSettingsResponse?> GetPlatformSettingsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.GetPlatformSettingsResponse>(_endpoints.GetPlatformSettings, null, cancellationToken);
    }
    public Task<Admin.ListEventsResponse?> ListEventsAsync(Admin.ListEventsRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<Admin.ListEventsResponse>(_endpoints.ListEvents, postaRequest, cancellationToken);
    }
    public Task<Admin.Disable2faForUserResponse?> Disable2faForUserAsync(Admin.Disable2faForUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.Disable2faForUserResponse>(_endpoints.Disable2faForUser, postaRequest, cancellationToken);
    }
    public Task<Admin.DeleteOauthProviderResponse?> DeleteOauthProviderAsync(Admin.DeleteOauthProviderRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.DeleteOauthProviderResponse>(_endpoints.DeleteOauthProvider, postaRequest, cancellationToken);
    }
    public Task<Admin.GetPlanResponse?> GetPlanAsync(Admin.GetPlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetPlanResponse>(_endpoints.GetPlan, postaRequest, cancellationToken);
    }
    public Task<Admin.GetUpdateStatusResponse?> GetUpdateStatusAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.GetUpdateStatusResponse>(_endpoints.GetUpdateStatus, null, cancellationToken);
    }
    public Task<Admin.UpdatePlanResponse?> UpdatePlanAsync(Admin.UpdatePlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.UpdatePlanResponse>(_endpoints.UpdatePlan, postaRequest, cancellationToken);
    }
    public Task<Admin.CreateANewUserResponse?> CreateANewUserAsync(Admin.CreateANewUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.CreateANewUserResponse>(_endpoints.CreateANewUser, postaRequest, cancellationToken);
    }
    public Task<Admin.GetWorkspacePlanResponse?> GetWorkspacePlanAsync(Admin.GetWorkspacePlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetWorkspacePlanResponse>(_endpoints.GetWorkspacePlan, postaRequest, cancellationToken);
    }
    public Task<Admin.SetPlanAsDefaultResponse?> SetPlanAsDefaultAsync(Admin.SetPlanAsDefaultRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.SetPlanAsDefaultResponse>(_endpoints.SetPlanAsDefault, postaRequest, cancellationToken);
    }
    public Task<Admin.ListScheduledJobsResponse?> ListScheduledJobsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.ListScheduledJobsResponse>(_endpoints.ListScheduledJobs, null, cancellationToken);
    }
    public Task<Admin.GetUserMetricsResponse?> GetUserMetricsAsync(Admin.GetUserMetricsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetUserMetricsResponse>(_endpoints.GetUserMetrics, postaRequest, cancellationToken);
    }
    public Task<Admin.GetSharedSmtpServerResponse?> GetSharedSmtpServerAsync(Admin.GetSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetSharedSmtpServerResponse>(_endpoints.GetSharedSmtpServer, postaRequest, cancellationToken);
    }
    public Task<Admin.ListUserWorkspacesResponse?> ListUserWorkspacesAsync(Admin.ListUserWorkspacesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.ListUserWorkspacesResponse>(_endpoints.ListUserWorkspaces, postaRequest, cancellationToken);
    }
    public Task<Admin.EnableSharedSmtpServerResponse?> EnableSharedSmtpServerAsync(Admin.EnableSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.EnableSharedSmtpServerResponse>(_endpoints.EnableSharedSmtpServer, postaRequest, cancellationToken);
    }
    public Task<Admin.TestSharedSmtpServerConnectionResponse?> TestSharedSmtpServerConnectionAsync(Admin.TestSharedSmtpServerConnectionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.TestSharedSmtpServerConnectionResponse>(_endpoints.TestSharedSmtpServerConnection, postaRequest, cancellationToken);
    }
    public Task<Admin.ListPlansResponse?> ListPlansAsync(Admin.ListPlansRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Admin.ListPlansResponse>(_endpoints.ListPlans, postaRequest, cancellationToken);
    }
    public Task<Admin.GetEventResponse?> GetEventAsync(Admin.GetEventRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetEventResponse>(_endpoints.GetEvent, postaRequest, cancellationToken);
    }
    public Task<Admin.ForceDeleteUserResponse?> ForceDeleteUserAsync(Admin.ForceDeleteUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.ForceDeleteUserResponse>(_endpoints.ForceDeleteUser, postaRequest, cancellationToken);
    }
    public Task<Admin.UpdateSharedSmtpServerResponse?> UpdateSharedSmtpServerAsync(Admin.UpdateSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.UpdateSharedSmtpServerResponse>(_endpoints.UpdateSharedSmtpServer, postaRequest, cancellationToken);
    }
    public Task<Admin.UpdateUserResponse?> UpdateUserAsync(Admin.UpdateUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.UpdateUserResponse>(_endpoints.UpdateUser, postaRequest, cancellationToken);
    }
    public Task<Admin.RevokeAllUserSessionsResponse?> RevokeAllUserSessionsAsync(Admin.RevokeAllUserSessionsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.RevokeAllUserSessionsResponse>(_endpoints.RevokeAllUserSessions, postaRequest, cancellationToken);
    }
    public Task<Admin.AssignPlanToUserResponse?> AssignPlanToUserAsync(Admin.AssignPlanToUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.AssignPlanToUserResponse>(_endpoints.AssignPlanToUser, postaRequest, cancellationToken);
    }
    public Task<Admin.ListAllOauthProvidersAdminResponse?> ListAllOauthProvidersAdminAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.ListAllOauthProvidersAdminResponse>(_endpoints.ListAllOauthProvidersAdmin, null, cancellationToken);
    }
    public Task<Admin.CancelUserDeletionResponse?> CancelUserDeletionAsync(Admin.CancelUserDeletionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.CancelUserDeletionResponse>(_endpoints.CancelUserDeletion, postaRequest, cancellationToken);
    }
    public Task<Admin.ListSharedSmtpServersResponse?> ListSharedSmtpServersAsync(Admin.ListSharedSmtpServersRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Admin.ListSharedSmtpServersResponse>(_endpoints.ListSharedSmtpServers, postaRequest, cancellationToken);
    }
    public Task<Admin.DeletePlanResponse?> DeletePlanAsync(Admin.DeletePlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
            Query = new Dictionary<string, object?>
            {
                ["force"] = request?.Force,
            },
        };

        return SendAsync<Admin.DeletePlanResponse>(_endpoints.DeletePlan, postaRequest, cancellationToken);
    }
    public Task<Admin.PlatformDeliverabilityByProviderResponse?> PlatformDeliverabilityByProviderAsync(Admin.PlatformDeliverabilityByProviderRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
            },
        };

        return SendAsync<Admin.PlatformDeliverabilityByProviderResponse>(_endpoints.PlatformDeliverabilityByProvider, postaRequest, cancellationToken);
    }
    public Task<Admin.CreatePlanResponse?> CreatePlanAsync(Admin.CreatePlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.CreatePlanResponse>(_endpoints.CreatePlan, postaRequest, cancellationToken);
    }
    public Task<Admin.DeleteSharedSmtpServerResponse?> DeleteSharedSmtpServerAsync(Admin.DeleteSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.DeleteSharedSmtpServerResponse>(_endpoints.DeleteSharedSmtpServer, postaRequest, cancellationToken);
    }
    public Task<Admin.CreateSharedSmtpServerResponse?> CreateSharedSmtpServerAsync(Admin.CreateSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.CreateSharedSmtpServerResponse>(_endpoints.CreateSharedSmtpServer, postaRequest, cancellationToken);
    }
    public Task<Admin.PlatformMetricsResponse?> PlatformMetricsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.PlatformMetricsResponse>(_endpoints.PlatformMetrics, null, cancellationToken);
    }
    public Task<Admin.DeleteUserResponse?> DeleteUserAsync(Admin.DeleteUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.DeleteUserResponse>(_endpoints.DeleteUser, postaRequest, cancellationToken);
    }
    public Task<Admin.UpdateOauthProviderResponse?> UpdateOauthProviderAsync(Admin.UpdateOauthProviderRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.UpdateOauthProviderResponse>(_endpoints.UpdateOauthProvider, postaRequest, cancellationToken);
    }
    public Task<Admin.DisableSharedSmtpServerResponse?> DisableSharedSmtpServerAsync(Admin.DisableSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.DisableSharedSmtpServerResponse>(_endpoints.DisableSharedSmtpServer, postaRequest, cancellationToken);
    }
}




