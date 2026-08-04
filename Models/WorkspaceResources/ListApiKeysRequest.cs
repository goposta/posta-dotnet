using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the ListApiKeysRequest payload.</summary>
public class ListApiKeysRequest : Shared.SearchableListRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

}
