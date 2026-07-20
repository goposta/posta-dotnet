using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the UpdateStylesheetRequest payload.</summary>
public class UpdateStylesheetRequest
{
    /// <summary>Gets or sets <c>css</c>.</summary>
    [JsonPropertyName("css")]
    public string? Css { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}