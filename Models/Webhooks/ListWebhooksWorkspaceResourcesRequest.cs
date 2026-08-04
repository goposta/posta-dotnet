using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the ListWebhooksWorkspaceResourcesRequest payload.</summary>
public class ListWebhooksWorkspaceResourcesRequest : Shared.SearchableListRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

}
