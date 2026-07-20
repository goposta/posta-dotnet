using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ImportWorkspaceDataRequestStylesheetsItem payload.</summary>
public class ImportWorkspaceDataRequestStylesheetsItem
{
    /// <summary>Gets or sets <c>css</c>.</summary>
    [JsonPropertyName("css")]
    public string? Css { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}