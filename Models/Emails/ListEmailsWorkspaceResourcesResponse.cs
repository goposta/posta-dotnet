using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the ListEmailsWorkspaceResourcesResponse payload.</summary>
public class ListEmailsWorkspaceResourcesResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListEmailsWorkspaceResourcesResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListEmailsWorkspaceResourcesResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}