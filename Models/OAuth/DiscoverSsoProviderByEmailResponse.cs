using System.Text.Json.Serialization;

namespace Posta.Models.OAuth;

/// <summary>Represents the DiscoverSsoProviderByEmailResponse payload.</summary>
public class DiscoverSsoProviderByEmailResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.DiscoverSsoProviderByEmailResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}