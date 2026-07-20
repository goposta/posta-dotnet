using System.Text.Json.Serialization;

namespace Posta.Models.UnsubscribeLists;

/// <summary>Represents the ListUnsubscribeListsResponse payload.</summary>
public class ListUnsubscribeListsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListUnsubscribeListsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListUnsubscribeListsResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}