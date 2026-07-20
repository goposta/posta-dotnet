using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the BulkImportSubscribersJsonResponseData payload.</summary>
public class BulkImportSubscribersJsonResponseData
{
    /// <summary>Gets or sets <c>created</c>.</summary>
    [JsonPropertyName("created")]
    public int? Created { get; set; }

    /// <summary>Gets or sets <c>skipped</c>.</summary>
    [JsonPropertyName("skipped")]
    public int? Skipped { get; set; }

    /// <summary>Gets or sets <c>total</c>.</summary>
    [JsonPropertyName("total")]
    public int? Total { get; set; }

}