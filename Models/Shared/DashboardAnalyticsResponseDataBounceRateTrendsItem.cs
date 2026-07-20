using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DashboardAnalyticsResponseDataBounceRateTrendsItem payload.</summary>
public class DashboardAnalyticsResponseDataBounceRateTrendsItem
{
    /// <summary>Gets or sets <c>complaint</c>.</summary>
    [JsonPropertyName("complaint")]
    public long? Complaint { get; set; }

    /// <summary>Gets or sets <c>date</c>.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Gets or sets <c>hard</c>.</summary>
    [JsonPropertyName("hard")]
    public long? Hard { get; set; }

    /// <summary>Gets or sets <c>soft</c>.</summary>
    [JsonPropertyName("soft")]
    public long? Soft { get; set; }

    /// <summary>Gets or sets <c>total</c>.</summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }

}