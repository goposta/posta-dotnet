using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the CreateLanguageRequest payload.</summary>
public class CreateLanguageRequest
{
    /// <summary>Gets or sets <c>code</c>.</summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

    /// <summary>Gets or sets <c>is_default</c>.</summary>
    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

}