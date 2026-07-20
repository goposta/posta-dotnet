using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the CreateOauthProviderResponse payload.</summary>
public class CreateOauthProviderResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateOauthProviderResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}