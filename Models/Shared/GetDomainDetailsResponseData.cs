using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetDomainDetailsResponseData payload.</summary>
public class GetDomainDetailsResponseData
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>dkim_verified</c>.</summary>
    [JsonPropertyName("dkim_verified")]
    public bool? DkimVerified { get; set; }

    /// <summary>Gets or sets <c>dmarc_verified</c>.</summary>
    [JsonPropertyName("dmarc_verified")]
    public bool? DmarcVerified { get; set; }

    /// <summary>Gets or sets <c>dns_records</c>.</summary>
    [JsonPropertyName("dns_records")]
    public GetDomainDetailsResponseDataDnsRecords? DnsRecords { get; set; }

    /// <summary>Gets or sets <c>domain</c>.</summary>
    [JsonPropertyName("domain")]
    public string? Domain { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>ownership_verified</c>.</summary>
    [JsonPropertyName("ownership_verified")]
    public bool? OwnershipVerified { get; set; }

    /// <summary>Gets or sets <c>spf_verified</c>.</summary>
    [JsonPropertyName("spf_verified")]
    public bool? SpfVerified { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>verification_token</c>.</summary>
    [JsonPropertyName("verification_token")]
    public string? VerificationToken { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}