using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the InviteMemberRequest payload.</summary>
public class InviteMemberRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Gets or sets <c>role</c>.</summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}