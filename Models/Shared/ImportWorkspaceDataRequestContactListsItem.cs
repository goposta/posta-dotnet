using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ImportWorkspaceDataRequestContactListsItem payload.</summary>
public class ImportWorkspaceDataRequestContactListsItem
{
    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>members</c>.</summary>
    [JsonPropertyName("members")]
    public IReadOnlyList<ImportWorkspaceDataRequestContactListsItemMembersItem>? Members { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}