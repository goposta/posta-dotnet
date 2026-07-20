using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetCampaignAnalyticsResponseClickSeriesItem payload.</summary>
public class GetCampaignAnalyticsResponseClickSeriesItem
{
    /// <summary>Gets or sets <c>count</c>.</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>Gets or sets <c>time</c>.</summary>
    [JsonPropertyName("time")]
    public string? Time { get; set; }

}