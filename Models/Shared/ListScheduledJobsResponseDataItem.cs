using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListScheduledJobsResponseDataItem payload.</summary>
public class ListScheduledJobsResponseDataItem
{
    /// <summary>Gets or sets <c>LastError</c>.</summary>
    [JsonPropertyName("LastError")]
    public string? LastError { get; set; }

    /// <summary>Gets or sets <c>LastRunAt</c>.</summary>
    [JsonPropertyName("LastRunAt")]
    public DateTimeOffset? LastRunAt { get; set; }

    /// <summary>Gets or sets <c>Name</c>.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>NextRunAt</c>.</summary>
    [JsonPropertyName("NextRunAt")]
    public DateTimeOffset? NextRunAt { get; set; }

    /// <summary>Gets or sets <c>Running</c>.</summary>
    [JsonPropertyName("Running")]
    public bool? Running { get; set; }

    /// <summary>Gets or sets <c>Schedule</c>.</summary>
    [JsonPropertyName("Schedule")]
    public string? Schedule { get; set; }

}