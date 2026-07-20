using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the AddDomainResponseDataDnsRecordsSpf payload.</summary>
public class AddDomainResponseDataDnsRecordsSpf
{
    /// <summary>Gets or sets <c>host</c>.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Gets or sets <c>type</c>.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets <c>value</c>.</summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

}