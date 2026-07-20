using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the DeleteWorkspaceEmailLogsGdprResponse payload.</summary>
public class DeleteWorkspaceEmailLogsGdprResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.DeleteWorkspaceEmailLogsGdprResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}