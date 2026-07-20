using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the ListWebhooksWorkspaceResourcesResponse payload.</summary>
public class ListWebhooksWorkspaceResourcesResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListWebhooksWorkspaceResourcesResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListWebhooksWorkspaceResourcesResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}