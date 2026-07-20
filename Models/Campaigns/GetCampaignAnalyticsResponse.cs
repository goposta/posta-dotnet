using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the GetCampaignAnalyticsResponse payload.</summary>
public class GetCampaignAnalyticsResponse
{
    /// <summary>Gets or sets <c>analytics</c>.</summary>
    [JsonPropertyName("analytics")]
    public Shared.GetCampaignAnalyticsResponseAnalytics? Analytics { get; set; }

    /// <summary>Gets or sets <c>click_series</c>.</summary>
    [JsonPropertyName("click_series")]
    public IReadOnlyList<Shared.GetCampaignAnalyticsResponseClickSeriesItem>? ClickSeries { get; set; }

    /// <summary>Gets or sets <c>links</c>.</summary>
    [JsonPropertyName("links")]
    public IReadOnlyList<Shared.GetCampaignAnalyticsResponseLinksItem>? Links { get; set; }

    /// <summary>Gets or sets <c>open_series</c>.</summary>
    [JsonPropertyName("open_series")]
    public IReadOnlyList<Shared.GetCampaignAnalyticsResponseOpenSeriesItem>? OpenSeries { get; set; }

    /// <summary>Gets or sets <c>variant_analytics</c>.</summary>
    [JsonPropertyName("variant_analytics")]
    public IReadOnlyDictionary<string, JsonElement>? VariantAnalytics { get; set; }

}