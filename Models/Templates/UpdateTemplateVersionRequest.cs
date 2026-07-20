using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the UpdateTemplateVersionRequest payload.</summary>
public class UpdateTemplateVersionRequest
{
    /// <summary>Gets or sets <c>stylesheet_id</c>.</summary>
    [JsonPropertyName("stylesheet_id")]
    public int? StylesheetId { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

    /// <summary>Gets or sets the <c>versionId</c> path parameter.</summary>
    [JsonIgnore]
    public required int VersionId { get; set; }

}