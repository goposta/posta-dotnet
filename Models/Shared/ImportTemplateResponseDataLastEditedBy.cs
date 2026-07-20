using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ImportTemplateResponseDataLastEditedBy payload.</summary>
public class ImportTemplateResponseDataLastEditedBy
{
    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}