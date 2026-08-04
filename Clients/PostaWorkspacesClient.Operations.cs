using Posta.Transport;
using Workspaces = Posta.Models.Workspaces;

namespace Posta.Clients;

public sealed partial class PostaWorkspacesClient
{
    public Task<Workspaces.GetCurrentWorkspaceResponse?> GetCurrentWorkspaceAsync(Workspaces.GetCurrentWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetCurrentWorkspaceResponse>(_endpoints.GetCurrentWorkspace, postaRequest, cancellationToken);
    }
    public Task<Workspaces.CancelInvitationResponse?> CancelInvitationAsync(Workspaces.CancelInvitationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["invitation_id"] = request?.InvitationId,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.CancelInvitationResponse>(_endpoints.CancelInvitation, postaRequest, cancellationToken);
    }
    public Task<Workspaces.UpdateWorkspaceResponse?> UpdateWorkspaceAsync(Workspaces.UpdateWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.UpdateWorkspaceResponse>(_endpoints.UpdateWorkspace, postaRequest, cancellationToken);
    }
    public Task<Workspaces.AcceptInvitationResponse?> AcceptInvitationAsync(Workspaces.AcceptInvitationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Workspaces.AcceptInvitationResponse>(_endpoints.AcceptInvitation, postaRequest, cancellationToken);
    }
    public Task<Workspaces.ListWorkspaceMembersResponse?> ListWorkspaceMembersAsync(Workspaces.ListWorkspaceMembersRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ListWorkspaceMembersResponse>(_endpoints.ListWorkspaceMembers, postaRequest, cancellationToken);
    }
    public Task<Workspaces.RemoveMemberResponse?> RemoveMemberAsync(Workspaces.RemoveMemberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["member_id"] = request?.MemberId,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.RemoveMemberResponse>(_endpoints.RemoveMember, postaRequest, cancellationToken);
    }
    public Task<Workspaces.GetWorkspaceSettingsResponse?> GetWorkspaceSettingsAsync(Workspaces.GetWorkspaceSettingsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetWorkspaceSettingsResponse>(_endpoints.GetWorkspaceSettings, postaRequest, cancellationToken);
    }
    public Task<Workspaces.SetWorkspaceSsoConfigResponse?> SetWorkspaceSsoConfigAsync(Workspaces.SetWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.SetWorkspaceSsoConfigResponse>(_endpoints.SetWorkspaceSsoConfig, postaRequest, cancellationToken);
    }
    public Task<Workspaces.DeclineInvitationByIdResponse?> DeclineInvitationByIdAsync(Workspaces.DeclineInvitationByIdRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Workspaces.DeclineInvitationByIdResponse>(_endpoints.DeclineInvitationById, postaRequest, cancellationToken);
    }
    public Task<Workspaces.CreateWorkspaceResponse?> CreateWorkspaceAsync(Workspaces.CreateWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Workspaces.CreateWorkspaceResponse>(_endpoints.CreateWorkspace, postaRequest, cancellationToken);
    }
    public Task<Workspaces.MyPendingInvitationsResponse?> MyPendingInvitationsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Workspaces.MyPendingInvitationsResponse>(_endpoints.MyPendingInvitations, null, cancellationToken);
    }
    public Task<Workspaces.DeleteWorkspaceEmailLogsGdprResponse?> DeleteWorkspaceEmailLogsGdprAsync(Workspaces.DeleteWorkspaceEmailLogsGdprRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.DeleteWorkspaceEmailLogsGdprResponse>(_endpoints.DeleteWorkspaceEmailLogsGdpr, postaRequest, cancellationToken);
    }
    public Task<Workspaces.GetWorkspacePlanWorkspacesResponse?> GetWorkspacePlanWorkspacesAsync(Workspaces.GetWorkspacePlanWorkspacesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetWorkspacePlanWorkspacesResponse>(_endpoints.GetWorkspacePlanWorkspaces, postaRequest, cancellationToken);
    }
    public Task<Workspaces.DeleteWorkspaceResponse?> DeleteWorkspaceAsync(Workspaces.DeleteWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.DeleteWorkspaceResponse>(_endpoints.DeleteWorkspace, postaRequest, cancellationToken);
    }
    public Task<Workspaces.ListPendingInvitationsResponse?> ListPendingInvitationsAsync(Workspaces.ListPendingInvitationsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ListPendingInvitationsResponse>(_endpoints.ListPendingInvitations, postaRequest, cancellationToken);
    }
    public Task<Workspaces.ListWorkspacesResponse?> ListWorkspacesAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Workspaces.ListWorkspacesResponse>(_endpoints.ListWorkspaces, null, cancellationToken);
    }
    public Task<Workspaces.UpdateWorkspaceSettingsResponse?> UpdateWorkspaceSettingsAsync(Workspaces.UpdateWorkspaceSettingsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.UpdateWorkspaceSettingsResponse>(_endpoints.UpdateWorkspaceSettings, postaRequest, cancellationToken);
    }
    public Task<Workspaces.DeleteWorkspaceSsoConfigResponse?> DeleteWorkspaceSsoConfigAsync(Workspaces.DeleteWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.DeleteWorkspaceSsoConfigResponse>(_endpoints.DeleteWorkspaceSsoConfig, postaRequest, cancellationToken);
    }
    public Task<Workspaces.GetWorkspaceAuditEventResponse?> GetWorkspaceAuditEventAsync(Workspaces.GetWorkspaceAuditEventRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetWorkspaceAuditEventResponse>(_endpoints.GetWorkspaceAuditEvent, postaRequest, cancellationToken);
    }
    public Task<Workspaces.AcceptInvitationByIdResponse?> AcceptInvitationByIdAsync(Workspaces.AcceptInvitationByIdRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Workspaces.AcceptInvitationByIdResponse>(_endpoints.AcceptInvitationById, postaRequest, cancellationToken);
    }
    public Task<Workspaces.ListWorkspaceAuditLogResponse?> ListWorkspaceAuditLogAsync(Workspaces.ListWorkspaceAuditLogRequest request, CancellationToken cancellationToken = default)
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
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ListWorkspaceAuditLogResponse>(_endpoints.ListWorkspaceAuditLog, postaRequest, cancellationToken);
    }
    public Task<Workspaces.ImportWorkspaceDataResponse?> ImportWorkspaceDataAsync(Workspaces.ImportWorkspaceDataRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ImportWorkspaceDataResponse>(_endpoints.ImportWorkspaceData, postaRequest, cancellationToken);
    }
    public Task<Workspaces.InviteMemberResponse?> InviteMemberAsync(Workspaces.InviteMemberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.InviteMemberResponse>(_endpoints.InviteMember, postaRequest, cancellationToken);
    }
    public Task<Workspaces.UpdateMemberRoleResponse?> UpdateMemberRoleAsync(Workspaces.UpdateMemberRoleRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["member_id"] = request?.MemberId,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.UpdateMemberRoleResponse>(_endpoints.UpdateMemberRole, postaRequest, cancellationToken);
    }
    public Task<Workspaces.GetWorkspaceSsoConfigResponse?> GetWorkspaceSsoConfigAsync(Workspaces.GetWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetWorkspaceSsoConfigResponse>(_endpoints.GetWorkspaceSsoConfig, postaRequest, cancellationToken);
    }
    public Task<Workspaces.DeleteWorkspaceContactDataGdprResponse?> DeleteWorkspaceContactDataGdprAsync(Workspaces.DeleteWorkspaceContactDataGdprRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.DeleteWorkspaceContactDataGdprResponse>(_endpoints.DeleteWorkspaceContactDataGdpr, postaRequest, cancellationToken);
    }
    public Task<Workspaces.DeclineInvitationByTokenResponse?> DeclineInvitationByTokenAsync(Workspaces.DeclineInvitationByTokenRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Workspaces.DeclineInvitationByTokenResponse>(_endpoints.DeclineInvitationByToken, postaRequest, cancellationToken);
    }
    public Task<Workspaces.ExportWorkspaceDataResponse?> ExportWorkspaceDataAsync(Workspaces.ExportWorkspaceDataRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ExportWorkspaceDataResponse>(_endpoints.ExportWorkspaceData, postaRequest, cancellationToken);
    }
}




