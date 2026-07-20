using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ImportWorkspaceDataRequestDomainsItem payload.</summary>
public class ImportWorkspaceDataRequestDomainsItem
{
    /// <summary>Gets or sets <c>domain</c>.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

}