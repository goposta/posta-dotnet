using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the GetWorkspacePlanWorkspacesRequest payload.</summary>
public class GetWorkspacePlanWorkspacesRequest
{
    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}