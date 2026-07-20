using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the ListWebhookDeliveriesResponse payload.</summary>
public class ListWebhookDeliveriesResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListWebhookDeliveriesResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListWebhookDeliveriesResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}