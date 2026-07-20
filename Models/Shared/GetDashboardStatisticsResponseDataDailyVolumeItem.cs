using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetDashboardStatisticsResponseDataDailyVolumeItem payload.</summary>
public class GetDashboardStatisticsResponseDataDailyVolumeItem
{
    /// <summary>Gets or sets <c>date</c>.</summary>
    [JsonPropertyName("date")]
    public string? Date { get; set; }

    /// <summary>Gets or sets <c>failed</c>.</summary>
    [JsonPropertyName("failed")]
    public long? Failed { get; set; }

    /// <summary>Gets or sets <c>sent</c>.</summary>
    [JsonPropertyName("sent")]
    public long? Sent { get; set; }

}