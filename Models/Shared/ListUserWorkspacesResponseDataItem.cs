using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListUserWorkspacesResponseDataItem payload.</summary>
public class ListUserWorkspacesResponseDataItem
{
    /// <summary>Gets or sets <c>CreatedAt</c>.</summary>
    [JsonPropertyName("CreatedAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>Id</c>.</summary>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>Name</c>.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>OwnerId</c>.</summary>
    [JsonPropertyName("OwnerId")]
    public int? OwnerId { get; set; }

    /// <summary>Gets or sets <c>PlanId</c>.</summary>
    [JsonPropertyName("PlanId")]
    public int? PlanId { get; set; }

    /// <summary>Gets or sets <c>PlanName</c>.</summary>
    [JsonPropertyName("PlanName")]
    public string? PlanName { get; set; }

    /// <summary>Gets or sets <c>Slug</c>.</summary>
    [JsonPropertyName("Slug")]
    public string? Slug { get; set; }

    /// <summary>Gets or sets <c>UpdatedAt</c>.</summary>
    [JsonPropertyName("UpdatedAt")]
    public DateTimeOffset? UpdatedAt { get; set; }

}