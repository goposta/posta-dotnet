using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the AddDomainResponseDataDnsRecords payload.</summary>
public class AddDomainResponseDataDnsRecords
{
    /// <summary>Gets or sets <c>dkim</c>.</summary>
    [JsonPropertyName("dkim")]
    public AddDomainResponseDataDnsRecordsDkim? Dkim { get; set; }

    /// <summary>Gets or sets <c>dmarc</c>.</summary>
    [JsonPropertyName("dmarc")]
    public AddDomainResponseDataDnsRecordsDmarc? Dmarc { get; set; }

    /// <summary>Gets or sets <c>spf</c>.</summary>
    [JsonPropertyName("spf")]
    public AddDomainResponseDataDnsRecordsSpf? Spf { get; set; }

    /// <summary>Gets or sets <c>verification</c>.</summary>
    [JsonPropertyName("verification")]
    public AddDomainResponseDataDnsRecordsVerification? Verification { get; set; }

}