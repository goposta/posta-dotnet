using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformAnalyticsResponseDataStatusBreakdownItem payload.</summary>
public class PlatformAnalyticsResponseDataStatusBreakdownItem
{
    /// <summary>Gets or sets <c>Count</c>.</summary>
    [JsonPropertyName("Count")]
    public long? Count { get; set; }

    /// <summary>Gets or sets <c>Status</c>.</summary>
    [JsonPropertyName("Status")]
    public string? Status { get; set; }

}