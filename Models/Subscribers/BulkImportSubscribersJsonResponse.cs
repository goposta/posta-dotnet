using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the BulkImportSubscribersJsonResponse payload.</summary>
public class BulkImportSubscribersJsonResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.BulkImportSubscribersJsonResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}