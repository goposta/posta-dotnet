using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetUserMetricsResponse payload.</summary>
public class GetUserMetricsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetUserMetricsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}