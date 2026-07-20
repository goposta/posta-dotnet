using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the EmailAnalyticsResponseData payload.</summary>
public class EmailAnalyticsResponseData
{
    /// <summary>Gets or sets <c>daily_counts</c>.</summary>
    [JsonPropertyName("daily_counts")]
    public IReadOnlyList<EmailAnalyticsResponseDataDailyCountsItem>? DailyCounts { get; set; }

    /// <summary>Gets or sets <c>status_breakdown</c>.</summary>
    [JsonPropertyName("status_breakdown")]
    public IReadOnlyList<EmailAnalyticsResponseDataStatusBreakdownItem>? StatusBreakdown { get; set; }

}