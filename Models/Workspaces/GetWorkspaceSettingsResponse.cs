using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the GetWorkspaceSettingsResponse payload.</summary>
public class GetWorkspaceSettingsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetWorkspaceSettingsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}