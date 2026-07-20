using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the BulkImportSubscribersJsonRequest payload.</summary>
public class BulkImportSubscribersJsonRequest
{
    /// <summary>Gets or sets <c>subscribers</c>.</summary>
    [JsonPropertyName("subscribers")]
    public required IReadOnlyList<Shared.BulkImportSubscribersJsonRequestSubscribersItem> Subscribers { get; set; }

}