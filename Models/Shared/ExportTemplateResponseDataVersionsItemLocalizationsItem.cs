using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportTemplateResponseDataVersionsItemLocalizationsItem payload.</summary>
public class ExportTemplateResponseDataVersionsItemLocalizationsItem
{
    /// <summary>Gets or sets <c>html_template</c>.</summary>
    [JsonPropertyName("html_template")]
    public string? HtmlTemplate { get; set; }

    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>Gets or sets <c>subject_template</c>.</summary>
    [JsonPropertyName("subject_template")]
    public string? SubjectTemplate { get; set; }

    /// <summary>Gets or sets <c>text_template</c>.</summary>
    [JsonPropertyName("text_template")]
    public string? TextTemplate { get; set; }

}