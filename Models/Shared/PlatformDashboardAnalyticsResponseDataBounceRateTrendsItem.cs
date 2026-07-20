using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformDashboardAnalyticsResponseDataBounceRateTrendsItem payload.</summary>
public class PlatformDashboardAnalyticsResponseDataBounceRateTrendsItem
{
    /// <summary>Gets or sets <c>Complaint</c>.</summary>
    [JsonPropertyName("Complaint")]
    public long? Complaint { get; set; }

    /// <summary>Gets or sets <c>Date</c>.</summary>
    [JsonPropertyName("Date")]
    public string? Date { get; set; }

    /// <summary>Gets or sets <c>Hard</c>.</summary>
    [JsonPropertyName("Hard")]
    public long? Hard { get; set; }

    /// <summary>Gets or sets <c>Soft</c>.</summary>
    [JsonPropertyName("Soft")]
    public long? Soft { get; set; }

    /// <summary>Gets or sets <c>Total</c>.</summary>
    [JsonPropertyName("Total")]
    public long? Total { get; set; }

}