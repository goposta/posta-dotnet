using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataWebhooksItem payload.</summary>
public class ExportWorkspaceDataResponseDataWebhooksItem
{
    /// <summary>Gets or sets <c>events</c>.</summary>
    [JsonPropertyName("events")]
    public IReadOnlyList<string>? Events { get; set; }

    /// <summary>Gets or sets <c>filters</c>.</summary>
    [JsonPropertyName("filters")]
    public IReadOnlyList<string>? Filters { get; set; }

    /// <summary>Gets or sets <c>url</c>.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

}