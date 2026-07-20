using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the UpdateWorkspaceRequest payload.</summary>
public class UpdateWorkspaceRequest
{
    /// <summary>Gets or sets <c>default_language</c>.</summary>
    [JsonPropertyName("default_language")]
    public string? DefaultLanguage { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}