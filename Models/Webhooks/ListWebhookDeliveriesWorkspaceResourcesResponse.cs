using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the ListWebhookDeliveriesWorkspaceResourcesResponse payload.</summary>
public class ListWebhookDeliveriesWorkspaceResourcesResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListWebhookDeliveriesWorkspaceResourcesResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListWebhookDeliveriesWorkspaceResourcesResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}