using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the GetCurrentWorkspaceResponse payload.</summary>
public class GetCurrentWorkspaceResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetCurrentWorkspaceResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}