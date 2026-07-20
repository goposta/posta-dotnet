using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the PreviewLocalizedTemplateRequest payload.</summary>
public class PreviewLocalizedTemplateRequest
{
    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public required string Language { get; set; }

    /// <summary>Gets or sets <c>template_data</c>.</summary>
    [JsonPropertyName("template_data")]
    public IReadOnlyDictionary<string, JsonElement>? TemplateData { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

    /// <summary>Gets or sets the <c>versionId</c> path parameter.</summary>
    [JsonIgnore]
    public required int VersionId { get; set; }

}