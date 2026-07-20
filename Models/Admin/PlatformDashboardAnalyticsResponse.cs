using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the PlatformDashboardAnalyticsResponse payload.</summary>
public class PlatformDashboardAnalyticsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.PlatformDashboardAnalyticsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}