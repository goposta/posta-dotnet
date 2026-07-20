using System.Text.Json.Serialization;

namespace Posta.Models.UnsubscribeLists;

/// <summary>Represents the ListUnsubscribeListsRequest payload.</summary>
public class ListUnsubscribeListsRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

}