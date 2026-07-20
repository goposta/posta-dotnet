using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataLanguagesItem payload.</summary>
public class ExportWorkspaceDataResponseDataLanguagesItem
{
    /// <summary>Gets or sets <c>code</c>.</summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}