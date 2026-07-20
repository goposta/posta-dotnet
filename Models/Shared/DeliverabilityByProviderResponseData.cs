using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DeliverabilityByProviderResponseData payload.</summary>
public class DeliverabilityByProviderResponseData
{
    /// <summary>Gets or sets <c>providers</c>.</summary>
    [JsonPropertyName("providers")]
    public IReadOnlyList<DeliverabilityByProviderResponseDataProvidersItem>? Providers { get; set; }

}