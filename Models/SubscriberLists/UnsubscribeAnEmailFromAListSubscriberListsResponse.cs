using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the UnsubscribeAnEmailFromAListSubscriberListsResponse payload.</summary>
public class UnsubscribeAnEmailFromAListSubscriberListsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UnsubscribeAnEmailFromAListSubscriberListsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}