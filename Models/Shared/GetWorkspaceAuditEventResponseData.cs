using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetWorkspaceAuditEventResponseData payload.</summary>
public class GetWorkspaceAuditEventResponseData
{
    /// <summary>Gets or sets <c>actor_id</c>.</summary>
    [JsonPropertyName("actor_id")]
    public int? ActorId { get; set; }

    /// <summary>Gets or sets <c>actor_name</c>.</summary>
    [JsonPropertyName("actor_name")]
    public string? ActorName { get; set; }

    /// <summary>Gets or sets <c>category</c>.</summary>
    [JsonPropertyName("category")]
    public string? Category { get; set; }

    /// <summary>Gets or sets <c>client_ip</c>.</summary>
    [JsonPropertyName("client_ip")]
    public string? ClientIp { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>message</c>.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

    /// <summary>Gets or sets <c>metadata</c>.</summary>
    [JsonPropertyName("metadata")]
    public string? Metadata { get; set; }

    /// <summary>Gets or sets <c>type</c>.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}