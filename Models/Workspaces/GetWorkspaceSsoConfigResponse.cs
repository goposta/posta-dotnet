using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the GetWorkspaceSsoConfigResponse payload.</summary>
public class GetWorkspaceSsoConfigResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetWorkspaceSsoConfigResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}