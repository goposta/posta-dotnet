using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the ListSubscribersRequest payload.</summary>
public class ListSubscribersRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

    /// <summary>Gets or sets the <c>search</c> query parameter.</summary>
    [JsonIgnore]
    public string? Search { get; set; }

    /// <summary>Gets or sets the <c>status</c> query parameter.</summary>
    [JsonIgnore]
    public string? Status { get; set; }

}