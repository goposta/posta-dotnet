using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataWorkspaceSettings payload.</summary>
public class ExportWorkspaceDataResponseDataWorkspaceSettings
{
    /// <summary>Gets or sets <c>default_language</c>.</summary>
    [JsonPropertyName("default_language")]
    public string? DefaultLanguage { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}