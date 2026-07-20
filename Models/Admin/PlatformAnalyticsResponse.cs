using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the PlatformAnalyticsResponse payload.</summary>
public class PlatformAnalyticsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.PlatformAnalyticsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}