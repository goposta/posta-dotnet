using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the CreateWebhookResponseData payload.</summary>
public class CreateWebhookResponseData
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>events</c>.</summary>
    [JsonPropertyName("events")]
    public IReadOnlyList<string>? Events { get; set; }

    /// <summary>Gets or sets <c>filters</c>.</summary>
    [JsonPropertyName("filters")]
    public IReadOnlyList<string>? Filters { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>secret</c>.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Gets or sets <c>url</c>.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}