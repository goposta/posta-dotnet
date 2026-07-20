using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataTemplatesItem payload.</summary>
public class ExportWorkspaceDataResponseDataTemplatesItem
{
    /// <summary>Gets or sets <c>default_language</c>.</summary>
    [JsonPropertyName("default_language")]
    public string? DefaultLanguage { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>exported_at</c>.</summary>
    [JsonPropertyName("exported_at")]
    public string? ExportedAt { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>posta_version</c>.</summary>
    [JsonPropertyName("posta_version")]
    public string? PostaVersion { get; set; }

    /// <summary>Gets or sets <c>sample_data</c>.</summary>
    [JsonPropertyName("sample_data")]
    public string? SampleData { get; set; }

    /// <summary>Gets or sets <c>versions</c>.</summary>
    [JsonPropertyName("versions")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataTemplatesItemVersionsItem>? Versions { get; set; }

}