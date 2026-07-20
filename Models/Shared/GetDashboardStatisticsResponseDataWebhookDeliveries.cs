using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetDashboardStatisticsResponseDataWebhookDeliveries payload.</summary>
public class GetDashboardStatisticsResponseDataWebhookDeliveries
{
    /// <summary>Gets or sets <c>failed_deliveries</c>.</summary>
    [JsonPropertyName("failed_deliveries")]
    public long? FailedDeliveries { get; set; }

    /// <summary>Gets or sets <c>success_deliveries</c>.</summary>
    [JsonPropertyName("success_deliveries")]
    public long? SuccessDeliveries { get; set; }

    /// <summary>Gets or sets <c>success_rate</c>.</summary>
    [JsonPropertyName("success_rate")]
    public double? SuccessRate { get; set; }

    /// <summary>Gets or sets <c>total_deliveries</c>.</summary>
    [JsonPropertyName("total_deliveries")]
    public long? TotalDeliveries { get; set; }

}