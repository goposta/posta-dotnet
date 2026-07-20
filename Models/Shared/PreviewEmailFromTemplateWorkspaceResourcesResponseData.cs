using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PreviewEmailFromTemplateWorkspaceResourcesResponseData payload.</summary>
public class PreviewEmailFromTemplateWorkspaceResourcesResponseData
{
    /// <summary>Gets or sets <c>html</c>.</summary>
    [JsonPropertyName("html")]
    public string? Html { get; set; }

    /// <summary>Gets or sets <c>subject</c>.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Gets or sets <c>text</c>.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

}