using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the DeleteWorkspaceEmailLogsGdprRequest payload.</summary>
public class DeleteWorkspaceEmailLogsGdprRequest
{
    /// <summary>Gets or sets <c>older_than_days</c>.</summary>
    [JsonPropertyName("older_than_days")]
    public int? OlderThanDays { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}