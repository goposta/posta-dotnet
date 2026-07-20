using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DashboardAnalyticsResponseDataDeliveryRateTrendsItem payload.</summary>
public class DashboardAnalyticsResponseDataDeliveryRateTrendsItem
{
    /// <summary>Gets or sets <c>date</c>.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Gets or sets <c>delivery_rate</c>.</summary>
    [JsonPropertyName("delivery_rate")]
    public double? DeliveryRate { get; set; }

    /// <summary>Gets or sets <c>failed</c>.</summary>
    [JsonPropertyName("failed")]
    public long? Failed { get; set; }

    /// <summary>Gets or sets <c>sent</c>.</summary>
    [JsonPropertyName("sent")]
    public long? Sent { get; set; }

    /// <summary>Gets or sets <c>total</c>.</summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }

}