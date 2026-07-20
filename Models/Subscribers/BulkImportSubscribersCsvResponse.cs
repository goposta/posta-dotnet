using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the BulkImportSubscribersCsvResponse payload.</summary>
public class BulkImportSubscribersCsvResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.BulkImportSubscribersCsvResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}