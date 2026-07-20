using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformDashboardAnalyticsResponseData payload.</summary>
public class PlatformDashboardAnalyticsResponseData
{
    /// <summary>Gets or sets <c>BounceRateTrends</c>.</summary>
    [JsonPropertyName("BounceRateTrends")]
    public IReadOnlyList<PlatformDashboardAnalyticsResponseDataBounceRateTrendsItem>? BounceRateTrends { get; set; }

    /// <summary>Gets or sets <c>DeliveryRateTrends</c>.</summary>
    [JsonPropertyName("DeliveryRateTrends")]
    public IReadOnlyList<PlatformDashboardAnalyticsResponseDataDeliveryRateTrendsItem>? DeliveryRateTrends { get; set; }

    /// <summary>Gets or sets <c>LatencyPercentiles</c>.</summary>
    [JsonPropertyName("LatencyPercentiles")]
    public PlatformDashboardAnalyticsResponseDataLatencyPercentiles? LatencyPercentiles { get; set; }

}