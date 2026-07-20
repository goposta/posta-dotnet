using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the VerifyDomainDnsRecordsResponse payload.</summary>
public class VerifyDomainDnsRecordsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public JsonElement? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}