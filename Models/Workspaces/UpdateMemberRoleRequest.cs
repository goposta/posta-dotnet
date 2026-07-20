using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the UpdateMemberRoleRequest payload.</summary>
public class UpdateMemberRoleRequest
{
    /// <summary>Gets or sets <c>role</c>.</summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    /// <summary>Gets or sets the <c>member_id</c> path parameter.</summary>
    [JsonIgnore]
    public required int MemberId { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}