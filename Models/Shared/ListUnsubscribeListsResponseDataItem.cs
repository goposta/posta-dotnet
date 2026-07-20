using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListUnsubscribeListsResponseDataItem payload.</summary>
public class ListUnsubscribeListsResponseDataItem
{
    /// <summary>Gets or sets <c>active</c>.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>public_name</c>.</summary>
    [JsonPropertyName("public_name")]
    public string? PublicName { get; set; }

    /// <summary>Gets or sets <c>updated_at</c>.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>uuid</c>.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}