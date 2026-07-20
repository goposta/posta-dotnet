using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the ListScheduledJobsResponse payload.</summary>
public class ListScheduledJobsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListScheduledJobsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}