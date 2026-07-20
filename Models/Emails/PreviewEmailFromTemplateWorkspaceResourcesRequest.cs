using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the PreviewEmailFromTemplateWorkspaceResourcesRequest payload.</summary>
public class PreviewEmailFromTemplateWorkspaceResourcesRequest
{
    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>Gets or sets <c>template</c>.</summary>
    [JsonPropertyName("template")]
    public string? Template { get; set; }

    /// <summary>Gets or sets <c>template_data</c>.</summary>
    [JsonPropertyName("template_data")]
    public IReadOnlyDictionary<string, JsonElement>? TemplateData { get; set; }

    /// <summary>Gets or sets <c>template_id</c>.</summary>
    [JsonPropertyName("template_id")]
    public int? TemplateId { get; set; }

}