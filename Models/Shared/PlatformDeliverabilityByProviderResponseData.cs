using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformDeliverabilityByProviderResponseData payload.</summary>
public class PlatformDeliverabilityByProviderResponseData
{
    /// <summary>Gets or sets <c>Providers</c>.</summary>
    [JsonPropertyName("Providers")]
    public IReadOnlyList<PlatformDeliverabilityByProviderResponseDataProvidersItem>? Providers { get; set; }

}