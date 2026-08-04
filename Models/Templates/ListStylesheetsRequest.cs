using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the ListStylesheetsRequest payload.</summary>
public class ListStylesheetsRequest : Shared.SearchableListRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

}
