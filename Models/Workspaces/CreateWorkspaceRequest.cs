using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the CreateWorkspaceRequest payload.</summary>
public class CreateWorkspaceRequest
{
    /// <summary>Gets or sets <c>default_language</c>.</summary>
    [JsonPropertyName("default_language")]
    public string? DefaultLanguage { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Gets or sets <c>slug</c>.</summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

}