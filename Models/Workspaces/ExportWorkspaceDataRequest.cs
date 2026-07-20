using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the ExportWorkspaceDataRequest payload.</summary>
public class ExportWorkspaceDataRequest
{
    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}