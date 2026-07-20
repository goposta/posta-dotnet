using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the GetWorkspaceAuditEventRequest payload.</summary>
public class GetWorkspaceAuditEventRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}