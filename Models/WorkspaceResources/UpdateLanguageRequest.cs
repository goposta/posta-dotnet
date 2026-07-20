using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the UpdateLanguageRequest payload.</summary>
public class UpdateLanguageRequest
{
    /// <summary>Gets or sets <c>code</c>.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Gets or sets <c>is_default</c>.</summary>
    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}