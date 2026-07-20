using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ImportWorkspaceDataRequestTemplatesItemVersionsItem payload.</summary>
public class ImportWorkspaceDataRequestTemplatesItemVersionsItem
{
    /// <summary>Gets or sets <c>is_active</c>.</summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }

    /// <summary>Gets or sets <c>localizations</c>.</summary>
    [JsonPropertyName("localizations")]
    public IReadOnlyList<ImportWorkspaceDataRequestTemplatesItemVersionsItemLocalizationsItem>? Localizations { get; set; }

    /// <summary>Gets or sets <c>sample_data</c>.</summary>
    [JsonPropertyName("sample_data")]
    public string? SampleData { get; set; }

    /// <summary>Gets or sets <c>stylesheet</c>.</summary>
    [JsonPropertyName("stylesheet")]
    public ImportWorkspaceDataRequestTemplatesItemVersionsItemStylesheet? Stylesheet { get; set; }

    /// <summary>Gets or sets <c>version</c>.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }

}