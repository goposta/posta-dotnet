using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the PreviewEmailFromTemplateWorkspaceResourcesResponse payload.</summary>
public class PreviewEmailFromTemplateWorkspaceResourcesResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.PreviewEmailFromTemplateWorkspaceResourcesResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}