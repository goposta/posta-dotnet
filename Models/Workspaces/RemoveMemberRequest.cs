using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the RemoveMemberRequest payload.</summary>
public class RemoveMemberRequest
{
    /// <summary>Gets or sets the <c>member_id</c> path parameter.</summary>
    [JsonIgnore]
    public required int MemberId { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}