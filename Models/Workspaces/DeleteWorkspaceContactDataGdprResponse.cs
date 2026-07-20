using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the DeleteWorkspaceContactDataGdprResponse payload.</summary>
public class DeleteWorkspaceContactDataGdprResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.DeleteWorkspaceContactDataGdprResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}