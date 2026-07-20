using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the ListSubscriberListsResponse payload.</summary>
public class ListSubscriberListsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListSubscriberListsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListSubscriberListsResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}