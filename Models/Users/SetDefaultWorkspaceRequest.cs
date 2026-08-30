using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the request used to select the current user's default workspace.</summary>
public sealed class SetDefaultWorkspaceRequest
{
    [JsonPropertyName("workspace_id")]
    public required int WorkspaceId { get; set; }
}
