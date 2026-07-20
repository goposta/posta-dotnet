using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the PlatformDeliverabilityByProviderResponse payload.</summary>
public class PlatformDeliverabilityByProviderResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.PlatformDeliverabilityByProviderResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}