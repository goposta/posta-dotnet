using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataContactListsItemMembersItem payload.</summary>
public class ExportWorkspaceDataResponseDataContactListsItemMembersItem
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public string? Data { get; set; }

    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}