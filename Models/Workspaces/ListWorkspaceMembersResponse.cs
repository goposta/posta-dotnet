using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the ListWorkspaceMembersResponse payload.</summary>
public class ListWorkspaceMembersResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListWorkspaceMembersResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}