using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the PlatformMetricsResponse payload.</summary>
public class PlatformMetricsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.PlatformMetricsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}