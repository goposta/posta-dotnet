using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the UnsubscribeAnEmailFromAListSubscriberListsRequest payload.</summary>
public class UnsubscribeAnEmailFromAListSubscriberListsRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Gets or sets <c>reason</c>.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}