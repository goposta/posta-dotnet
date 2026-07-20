using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListPlansResponsePageable payload.</summary>
public class ListPlansResponsePageable
{
    /// <summary>Gets or sets <c>CurrentPage</c>.</summary>
    [JsonPropertyName("CurrentPage")]
    public int? CurrentPage { get; set; }

    /// <summary>Gets or sets <c>Empty</c>.</summary>
    [JsonPropertyName("Empty")]
    public bool? Empty { get; set; }

    /// <summary>Gets or sets <c>Size</c>.</summary>
    [JsonPropertyName("Size")]
    public int? Size { get; set; }

    /// <summary>Gets or sets <c>TotalElements</c>.</summary>
    [JsonPropertyName("TotalElements")]
    public long? TotalElements { get; set; }

    /// <summary>Gets or sets <c>TotalPages</c>.</summary>
    [JsonPropertyName("TotalPages")]
    public int? TotalPages { get; set; }

}