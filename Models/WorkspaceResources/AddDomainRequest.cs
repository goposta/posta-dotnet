using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the AddDomainRequest payload.</summary>
public class AddDomainRequest
{
    /// <summary>Gets or sets <c>domain</c>.</summary>
    [JsonPropertyName("domain")]
    public required string Domain { get; set; }

}