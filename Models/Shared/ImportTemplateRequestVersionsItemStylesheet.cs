using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ImportTemplateRequestVersionsItemStylesheet payload.</summary>
public class ImportTemplateRequestVersionsItemStylesheet
{
    /// <summary>Gets or sets <c>css</c>.</summary>
    [JsonPropertyName("css")]
    public string? Css { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}