using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the CreateTemplateVersionRequest payload.</summary>
public class CreateTemplateVersionRequest
{
    /// <summary>Gets or sets <c>sample_data</c>.</summary>
    [JsonPropertyName("sample_data")]
    public string? SampleData { get; set; }

    /// <summary>Gets or sets <c>stylesheet_id</c>.</summary>
    [JsonPropertyName("stylesheet_id")]
    public int? StylesheetId { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}