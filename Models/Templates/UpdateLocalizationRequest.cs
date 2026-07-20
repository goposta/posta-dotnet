using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the UpdateLocalizationRequest payload.</summary>
public class UpdateLocalizationRequest
{
    /// <summary>Gets or sets <c>builder_json</c>.</summary>
    [JsonPropertyName("builder_json")]
    public string? BuilderJson { get; set; }

    /// <summary>Gets or sets <c>html_template</c>.</summary>
    [JsonPropertyName("html_template")]
    public string? HtmlTemplate { get; set; }

    /// <summary>Gets or sets <c>subject_template</c>.</summary>
    [JsonPropertyName("subject_template")]
    public string? SubjectTemplate { get; set; }

    /// <summary>Gets or sets <c>text_template</c>.</summary>
    [JsonPropertyName("text_template")]
    public string? TextTemplate { get; set; }

    /// <summary>Gets or sets the <c>localizationId</c> path parameter.</summary>
    [JsonIgnore]
    public required int LocalizationId { get; set; }

}