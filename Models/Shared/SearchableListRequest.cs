using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Common search and sort parameters exposed by Posta list endpoints.</summary>
public abstract class SearchableListRequest
{
    /// <summary>Gets or sets the free-text search query.</summary>
    [JsonIgnore]
    public string? Q { get; set; }

    /// <summary>Gets or sets the API sort expression.</summary>
    [JsonIgnore]
    public string? Sort { get; set; }
}
