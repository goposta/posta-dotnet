using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetUserMetricsResponseDataWebhookDeliveries payload.</summary>
public class GetUserMetricsResponseDataWebhookDeliveries
{
    /// <summary>Gets or sets <c>FailedDeliveries</c>.</summary>
    [JsonPropertyName("FailedDeliveries")]
    public long? FailedDeliveries { get; set; }

    /// <summary>Gets or sets <c>SuccessDeliveries</c>.</summary>
    [JsonPropertyName("SuccessDeliveries")]
    public long? SuccessDeliveries { get; set; }

    /// <summary>Gets or sets <c>SuccessRate</c>.</summary>
    [JsonPropertyName("SuccessRate")]
    public double? SuccessRate { get; set; }

    /// <summary>Gets or sets <c>TotalDeliveries</c>.</summary>
    [JsonPropertyName("TotalDeliveries")]
    public long? TotalDeliveries { get; set; }

}