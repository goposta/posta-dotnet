using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the CreateStylesheetRequest payload.</summary>
public class CreateStylesheetRequest
{
    /// <summary>Gets or sets <c>css</c>.</summary>
    [JsonPropertyName("css")]
    public string? Css { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

}