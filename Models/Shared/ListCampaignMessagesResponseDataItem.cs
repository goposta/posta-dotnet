using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListCampaignMessagesResponseDataItem payload.</summary>
public class ListCampaignMessagesResponseDataItem
{
    /// <summary>Gets or sets <c>bounced_at</c>.</summary>
    [JsonPropertyName("bounced_at")]
    public DateTimeOffset? BouncedAt { get; set; }

    /// <summary>Gets or sets <c>campaign_id</c>.</summary>
    [JsonPropertyName("campaign_id")]
    public int? CampaignId { get; set; }

    /// <summary>Gets or sets <c>clicked_at</c>.</summary>
    [JsonPropertyName("clicked_at")]
    public DateTimeOffset? ClickedAt { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>email_id</c>.</summary>
    [JsonPropertyName("email_id")]
    public int? EmailId { get; set; }

    /// <summary>Gets or sets <c>error_message</c>.</summary>
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>opened_at</c>.</summary>
    [JsonPropertyName("opened_at")]
    public DateTimeOffset? OpenedAt { get; set; }

    /// <summary>Gets or sets <c>sent_at</c>.</summary>
    [JsonPropertyName("sent_at")]
    public DateTimeOffset? SentAt { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>subscriber_id</c>.</summary>
    [JsonPropertyName("subscriber_id")]
    public int? SubscriberId { get; set; }

    /// <summary>Gets or sets <c>unsubscribed_at</c>.</summary>
    [JsonPropertyName("unsubscribed_at")]
    public DateTimeOffset? UnsubscribedAt { get; set; }

    /// <summary>Gets or sets <c>variant</c>.</summary>
    [JsonPropertyName("variant")]
    public string? Variant { get; set; }

}