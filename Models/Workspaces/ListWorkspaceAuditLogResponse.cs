using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the ListWorkspaceAuditLogResponse payload.</summary>
public class ListWorkspaceAuditLogResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListWorkspaceAuditLogResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListWorkspaceAuditLogResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}