using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the ListWorkspaceAuditLogRequest payload.</summary>
public class ListWorkspaceAuditLogRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

    /// <summary>Gets or sets the <c>category</c> query parameter.</summary>
    [JsonIgnore]
    public string? Category { get; set; }

    /// <summary>Gets or sets the <c>search</c> query parameter.</summary>
    [JsonIgnore]
    public string? Search { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}