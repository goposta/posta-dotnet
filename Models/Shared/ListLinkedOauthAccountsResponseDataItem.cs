using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListLinkedOauthAccountsResponseDataItem payload.</summary>
public class ListLinkedOauthAccountsResponseDataItem
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>provider_id</c>.</summary>
    [JsonPropertyName("provider_id")]
    public int? ProviderId { get; set; }

    /// <summary>Gets or sets <c>provider_name</c>.</summary>
    [JsonPropertyName("provider_name")]
    public string? ProviderName { get; set; }

    /// <summary>Gets or sets <c>provider_type</c>.</summary>
    [JsonPropertyName("provider_type")]
    public string? ProviderType { get; set; }

}