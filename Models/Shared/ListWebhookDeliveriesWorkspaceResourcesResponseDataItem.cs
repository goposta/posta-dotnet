using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListWebhookDeliveriesWorkspaceResourcesResponseDataItem payload.</summary>
public class ListWebhookDeliveriesWorkspaceResourcesResponseDataItem
{
    /// <summary>Gets or sets <c>attempt</c>.</summary>
    [JsonPropertyName("attempt")]
    public int? Attempt { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>error_message</c>.</summary>
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; set; }

    /// <summary>Gets or sets <c>event</c>.</summary>
    [JsonPropertyName("event")]
    public string? Event { get; set; }

    /// <summary>Gets or sets <c>http_status_code</c>.</summary>
    [JsonPropertyName("http_status_code")]
    public int? HttpStatusCode { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>webhook_id</c>.</summary>
    [JsonPropertyName("webhook_id")]
    public int? WebhookId { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}