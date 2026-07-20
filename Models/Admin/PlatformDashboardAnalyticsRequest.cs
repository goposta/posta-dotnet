using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the PlatformDashboardAnalyticsRequest payload.</summary>
public class PlatformDashboardAnalyticsRequest
{
    /// <summary>Gets or sets the <c>from</c> query parameter.</summary>
    [JsonIgnore]
    public string? From { get; set; }

    /// <summary>Gets or sets the <c>to</c> query parameter.</summary>
    [JsonIgnore]
    public string? To { get; set; }

}