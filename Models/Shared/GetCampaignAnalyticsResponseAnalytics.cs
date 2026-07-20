using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetCampaignAnalyticsResponseAnalytics payload.</summary>
public class GetCampaignAnalyticsResponseAnalytics
{
    /// <summary>Gets or sets <c>bounce_rate</c>.</summary>
    [JsonPropertyName("bounce_rate")]
    public double? BounceRate { get; set; }

    /// <summary>Gets or sets <c>bounced_messages</c>.</summary>
    [JsonPropertyName("bounced_messages")]
    public long? BouncedMessages { get; set; }

    /// <summary>Gets or sets <c>click_rate</c>.</summary>
    [JsonPropertyName("click_rate")]
    public double? ClickRate { get; set; }

    /// <summary>Gets or sets <c>clicked_messages</c>.</summary>
    [JsonPropertyName("clicked_messages")]
    public long? ClickedMessages { get; set; }

    /// <summary>Gets or sets <c>delivery_rate</c>.</summary>
    [JsonPropertyName("delivery_rate")]
    public double? DeliveryRate { get; set; }

    /// <summary>Gets or sets <c>failed_messages</c>.</summary>
    [JsonPropertyName("failed_messages")]
    public long? FailedMessages { get; set; }

    /// <summary>Gets or sets <c>open_rate</c>.</summary>
    [JsonPropertyName("open_rate")]
    public double? OpenRate { get; set; }

    /// <summary>Gets or sets <c>opened_messages</c>.</summary>
    [JsonPropertyName("opened_messages")]
    public long? OpenedMessages { get; set; }

    /// <summary>Gets or sets <c>sent_messages</c>.</summary>
    [JsonPropertyName("sent_messages")]
    public long? SentMessages { get; set; }

    /// <summary>Gets or sets <c>total_messages</c>.</summary>
    [JsonPropertyName("total_messages")]
    public long? TotalMessages { get; set; }

    /// <summary>Gets or sets <c>unsubscribe_rate</c>.</summary>
    [JsonPropertyName("unsubscribe_rate")]
    public double? UnsubscribeRate { get; set; }

    /// <summary>Gets or sets <c>unsubscribed</c>.</summary>
    [JsonPropertyName("unsubscribed")]
    public long? Unsubscribed { get; set; }

}