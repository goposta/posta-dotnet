using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the ListEventsResponse payload.</summary>
public class ListEventsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListEventsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListEventsResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}