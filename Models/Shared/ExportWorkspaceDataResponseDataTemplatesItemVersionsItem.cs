using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataTemplatesItemVersionsItem payload.</summary>
public class ExportWorkspaceDataResponseDataTemplatesItemVersionsItem
{
    /// <summary>Gets or sets <c>is_active</c>.</summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }

    /// <summary>Gets or sets <c>localizations</c>.</summary>
    [JsonPropertyName("localizations")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataTemplatesItemVersionsItemLocalizationsItem>? Localizations { get; set; }

    /// <summary>Gets or sets <c>sample_data</c>.</summary>
    [JsonPropertyName("sample_data")]
    public string? SampleData { get; set; }

    /// <summary>Gets or sets <c>stylesheet</c>.</summary>
    [JsonPropertyName("stylesheet")]
    public ExportWorkspaceDataResponseDataTemplatesItemVersionsItemStylesheet? Stylesheet { get; set; }

    /// <summary>Gets or sets <c>version</c>.</summary>
    [JsonPropertyName("version")]
    public int? Version { get; set; }

}