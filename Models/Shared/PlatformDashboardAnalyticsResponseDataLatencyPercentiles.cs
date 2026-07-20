using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformDashboardAnalyticsResponseDataLatencyPercentiles payload.</summary>
public class PlatformDashboardAnalyticsResponseDataLatencyPercentiles
{
    /// <summary>Gets or sets <c>Avg</c>.</summary>
    [JsonPropertyName("Avg")]
    public double? Avg { get; set; }

    /// <summary>Gets or sets <c>P50</c>.</summary>
    [JsonPropertyName("P50")]
    public double? P50 { get; set; }

    /// <summary>Gets or sets <c>P75</c>.</summary>
    [JsonPropertyName("P75")]
    public double? P75 { get; set; }

    /// <summary>Gets or sets <c>P90</c>.</summary>
    [JsonPropertyName("P90")]
    public double? P90 { get; set; }

    /// <summary>Gets or sets <c>P99</c>.</summary>
    [JsonPropertyName("P99")]
    public double? P99 { get; set; }

}