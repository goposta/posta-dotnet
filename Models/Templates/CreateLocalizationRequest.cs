using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the CreateLocalizationRequest payload.</summary>
public class CreateLocalizationRequest
{
    /// <summary>Gets or sets <c>builder_json</c>.</summary>
    [JsonPropertyName("builder_json")]
    public string? BuilderJson { get; set; }

    /// <summary>Gets or sets <c>html_template</c>.</summary>
    [JsonPropertyName("html_template")]
    public string? HtmlTemplate { get; set; }

    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public required string Language { get; set; }

    /// <summary>Gets or sets <c>subject_template</c>.</summary>
    [JsonPropertyName("subject_template")]
    public required string SubjectTemplate { get; set; }

    /// <summary>Gets or sets <c>text_template</c>.</summary>
    [JsonPropertyName("text_template")]
    public string? TextTemplate { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

    /// <summary>Gets or sets the <c>versionId</c> path parameter.</summary>
    [JsonIgnore]
    public required int VersionId { get; set; }

}