using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataDomainsItem payload.</summary>
public class ExportWorkspaceDataResponseDataDomainsItem
{
    /// <summary>Gets or sets <c>domain</c>.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

}