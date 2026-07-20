using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformAnalyticsResponseDataDailyCountsItem payload.</summary>
public class PlatformAnalyticsResponseDataDailyCountsItem
{
    /// <summary>Gets or sets <c>Count</c>.</summary>
    [JsonPropertyName("Count")]
    public long? Count { get; set; }

    /// <summary>Gets or sets <c>Date</c>.</summary>
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

}