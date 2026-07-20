using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the ExportWorkspaceDataResponse payload.</summary>
public class ExportWorkspaceDataResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.ExportWorkspaceDataResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}