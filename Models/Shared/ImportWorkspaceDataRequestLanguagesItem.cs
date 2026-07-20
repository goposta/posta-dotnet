using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ImportWorkspaceDataRequestLanguagesItem payload.</summary>
public class ImportWorkspaceDataRequestLanguagesItem
{
    /// <summary>Gets or sets <c>code</c>.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}