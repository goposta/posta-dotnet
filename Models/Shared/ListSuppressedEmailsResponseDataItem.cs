using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListSuppressedEmailsResponseDataItem payload.</summary>
public class ListSuppressedEmailsResponseDataItem
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>kind</c>.</summary>
    [JsonPropertyName("kind")]
    public string? Kind { get; set; }

    /// <summary>Gets or sets <c>list_id</c>.</summary>
    [JsonPropertyName("list_id")]
    public int? ListId { get; set; }

    /// <summary>Gets or sets <c>reason</c>.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}