using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the UpdateWorkspaceResponse payload.</summary>
public class UpdateWorkspaceResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdateWorkspaceResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}