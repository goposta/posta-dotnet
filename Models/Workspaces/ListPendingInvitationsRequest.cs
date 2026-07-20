using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the ListPendingInvitationsRequest payload.</summary>
public class ListPendingInvitationsRequest
{
    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}