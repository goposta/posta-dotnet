using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetDomainDetailsResponseDataDnsRecords payload.</summary>
public class GetDomainDetailsResponseDataDnsRecords
{
    /// <summary>Gets or sets <c>dkim</c>.</summary>
    [JsonPropertyName("dkim")]
    public GetDomainDetailsResponseDataDnsRecordsDkim? Dkim { get; set; }

    /// <summary>Gets or sets <c>dmarc</c>.</summary>
    [JsonPropertyName("dmarc")]
    public GetDomainDetailsResponseDataDnsRecordsDmarc? Dmarc { get; set; }

    /// <summary>Gets or sets <c>spf</c>.</summary>
    [JsonPropertyName("spf")]
    public GetDomainDetailsResponseDataDnsRecordsSpf? Spf { get; set; }

    /// <summary>Gets or sets <c>verification</c>.</summary>
    [JsonPropertyName("verification")]
    public GetDomainDetailsResponseDataDnsRecordsVerification? Verification { get; set; }

}