using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the DashboardAnalyticsResponse payload.</summary>
public class DashboardAnalyticsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.DashboardAnalyticsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}