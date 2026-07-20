using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetCampaignAnalyticsResponseLinksItem payload.</summary>
public class GetCampaignAnalyticsResponseLinksItem
{
    /// <summary>Gets or sets <c>campaign_id</c>.</summary>
    [JsonPropertyName("campaign_id")]
    public int? CampaignId { get; set; }

    /// <summary>Gets or sets <c>click_count</c>.</summary>
    [JsonPropertyName("click_count")]
    public long? ClickCount { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>hash</c>.</summary>
    [JsonPropertyName("hash")]
    public string? Hash { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>original_url</c>.</summary>
    [JsonPropertyName("original_url")]
    public string? OriginalUrl { get; set; }

}