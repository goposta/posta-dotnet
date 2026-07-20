using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformDashboardAnalyticsResponseDataDeliveryRateTrendsItem payload.</summary>
public class PlatformDashboardAnalyticsResponseDataDeliveryRateTrendsItem
{
    /// <summary>Gets or sets <c>Date</c>.</summary>
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>Gets or sets <c>DeliveryRate</c>.</summary>
    [JsonPropertyName("DeliveryRate")]
    public double? DeliveryRate { get; set; }

    /// <summary>Gets or sets <c>Failed</c>.</summary>
    [JsonPropertyName("Failed")]
    public long? Failed { get; set; }

    /// <summary>Gets or sets <c>Sent</c>.</summary>
    [JsonPropertyName("Sent")]
    public long? Sent { get; set; }

    /// <summary>Gets or sets <c>Total</c>.</summary>
    [JsonPropertyName("Total")]
    public long? Total { get; set; }

}