using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the PreviewSegmentCountRequest payload.</summary>
public class PreviewSegmentCountRequest
{
    /// <summary>Gets or sets <c>filter_rules</c>.</summary>
    [JsonPropertyName("filter_rules")]
    public required IReadOnlyList<Shared.PreviewSegmentCountRequestFilterRulesItem> FilterRules { get; set; }

}