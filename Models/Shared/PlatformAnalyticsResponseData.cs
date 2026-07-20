using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformAnalyticsResponseData payload.</summary>
public class PlatformAnalyticsResponseData
{
    /// <summary>Gets or sets <c>DailyCounts</c>.</summary>
    [JsonPropertyName("DailyCounts")]
    public IReadOnlyList<PlatformAnalyticsResponseDataDailyCountsItem>? DailyCounts { get; set; }

    /// <summary>Gets or sets <c>StatusBreakdown</c>.</summary>
    [JsonPropertyName("StatusBreakdown")]
    public IReadOnlyList<PlatformAnalyticsResponseDataStatusBreakdownItem>? StatusBreakdown { get; set; }

}