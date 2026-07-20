using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DashboardAnalyticsResponseData payload.</summary>
public class DashboardAnalyticsResponseData
{
    /// <summary>Gets or sets <c>bounce_rate_trends</c>.</summary>
    [JsonPropertyName("bounce_rate_trends")]
    public IReadOnlyList<DashboardAnalyticsResponseDataBounceRateTrendsItem>? BounceRateTrends { get; set; }

    /// <summary>Gets or sets <c>delivery_rate_trends</c>.</summary>
    [JsonPropertyName("delivery_rate_trends")]
    public IReadOnlyList<DashboardAnalyticsResponseDataDeliveryRateTrendsItem>? DeliveryRateTrends { get; set; }

    /// <summary>Gets or sets <c>latency_percentiles</c>.</summary>
    [JsonPropertyName("latency_percentiles")]
    public DashboardAnalyticsResponseDataLatencyPercentiles? LatencyPercentiles { get; set; }

}