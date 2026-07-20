using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the ListSubscriberListsRequest payload.</summary>
public class ListSubscriberListsRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

}