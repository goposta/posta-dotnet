using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataContactListsItem payload.</summary>
public class ExportWorkspaceDataResponseDataContactListsItem
{
    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>members</c>.</summary>
    [JsonPropertyName("members")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataContactListsItemMembersItem>? Members { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}