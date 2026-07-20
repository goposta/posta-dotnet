using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListApiKeysResponseDataItem payload.</summary>
public class ListApiKeysResponseDataItem
{
    /// <summary>Gets or sets <c>allowed_ips</c>.</summary>
    [JsonPropertyName("allowed_ips")]
    public IReadOnlyList<string>? AllowedIps { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>created_by</c>.</summary>
    [JsonPropertyName("created_by")]
    public ListApiKeysResponseDataItemCreatedBy? CreatedBy { get; set; }

    /// <summary>Gets or sets <c>expires_at</c>.</summary>
    [JsonPropertyName("expires_at")]
    public DateTimeOffset? ExpiresAt { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>key_prefix</c>.</summary>
    [JsonPropertyName("key_prefix")]
    public string? KeyPrefix { get; set; }

    /// <summary>Gets or sets <c>last_used_at</c>.</summary>
    [JsonPropertyName("last_used_at")]
    public DateTimeOffset? LastUsedAt { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>revoked</c>.</summary>
    [JsonPropertyName("revoked")]
    public bool? Revoked { get; set; }

    /// <summary>Gets or sets <c>scopes</c>.</summary>
    [JsonPropertyName("scopes")]
    public IReadOnlyList<string>? Scopes { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}