using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the ListMembersOfSubscriberListResponse payload.</summary>
public class ListMembersOfSubscriberListResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListMembersOfSubscriberListResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListMembersOfSubscriberListResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}