using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the CreateSubscriberResponseData payload.</summary>
public class CreateSubscriberResponseData
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>custom_fields</c>.</summary>
    [JsonPropertyName("custom_fields")]
    public IReadOnlyDictionary<string, JsonElement>? CustomFields { get; set; }

    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>subscribed_at</c>.</summary>
    [JsonPropertyName("subscribed_at")]
    public DateTimeOffset? SubscribedAt { get; set; }

    /// <summary>Gets or sets <c>timezone</c>.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Gets or sets <c>unsubscribed_at</c>.</summary>
    [JsonPropertyName("unsubscribed_at")]
    public DateTimeOffset? UnsubscribedAt { get; set; }

    /// <summary>Gets or sets <c>updated_at</c>.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}