using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the ListContactsRequest payload.</summary>
public class ListContactsRequest
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

}