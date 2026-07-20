using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the CancelInvitationRequest payload.</summary>
public class CancelInvitationRequest
{
    /// <summary>Gets or sets the <c>invitation_id</c> path parameter.</summary>
    [JsonIgnore]
    public required int InvitationId { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}