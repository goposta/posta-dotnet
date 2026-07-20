using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the CreateWorkspaceResponseData payload.</summary>
public class CreateWorkspaceResponseData
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>is_personal</c>.</summary>
    [JsonPropertyName("is_personal")]
    public bool? IsPersonal { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>owner_id</c>.</summary>
    [JsonPropertyName("owner_id")]
    public int? OwnerId { get; set; }

    /// <summary>Gets or sets <c>role</c>.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Gets or sets <c>slug</c>.</summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

}