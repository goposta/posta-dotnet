using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the EmailAnalyticsResponseDataDailyCountsItem payload.</summary>
public class EmailAnalyticsResponseDataDailyCountsItem
{
    /// <summary>Gets or sets <c>count</c>.</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>Gets or sets <c>date</c>.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

}