using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DashboardAnalyticsResponseDataLatencyPercentiles payload.</summary>
public class DashboardAnalyticsResponseDataLatencyPercentiles
{
    /// <summary>Gets or sets <c>avg</c>.</summary>
    [JsonPropertyName("avg")]
    public double? Avg { get; set; }

    /// <summary>Gets or sets <c>p50</c>.</summary>
    [JsonPropertyName("p50")]
    public double? P50 { get; set; }

    /// <summary>Gets or sets <c>p75</c>.</summary>
    [JsonPropertyName("p75")]
    public double? P75 { get; set; }

    /// <summary>Gets or sets <c>p90</c>.</summary>
    [JsonPropertyName("p90")]
    public double? P90 { get; set; }

    /// <summary>Gets or sets <c>p99</c>.</summary>
    [JsonPropertyName("p99")]
    public double? P99 { get; set; }

}