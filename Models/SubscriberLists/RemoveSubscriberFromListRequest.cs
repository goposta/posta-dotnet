using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the RemoveSubscriberFromListRequest payload.</summary>
public class RemoveSubscriberFromListRequest
{
    /// <summary>Gets or sets <c>subscriber_id</c>.</summary>
    [JsonPropertyName("subscriber_id")]
    public required int SubscriberId { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}