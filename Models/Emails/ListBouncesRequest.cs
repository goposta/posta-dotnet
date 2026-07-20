using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the ListBouncesRequest payload.</summary>
public class ListBouncesRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

}