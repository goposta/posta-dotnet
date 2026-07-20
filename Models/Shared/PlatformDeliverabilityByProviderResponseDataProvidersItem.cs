using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformDeliverabilityByProviderResponseDataProvidersItem payload.</summary>
public class PlatformDeliverabilityByProviderResponseDataProvidersItem
{
    /// <summary>Gets or sets <c>Bounced</c>.</summary>
    [JsonPropertyName("Bounced")]
    public long? Bounced { get; set; }

    /// <summary>Gets or sets <c>DeliveryRate</c>.</summary>
    [JsonPropertyName("DeliveryRate")]
    public double? DeliveryRate { get; set; }

    /// <summary>Gets or sets <c>Failed</c>.</summary>
    [JsonPropertyName("Failed")]
    public long? Failed { get; set; }

    /// <summary>Gets or sets <c>Provider</c>.</summary>
    [JsonPropertyName("Provider")]
    public string? Provider { get; set; }

    /// <summary>Gets or sets <c>Sent</c>.</summary>
    [JsonPropertyName("Sent")]
    public long? Sent { get; set; }

    /// <summary>Gets or sets <c>Total</c>.</summary>
    [JsonPropertyName("Total")]
    public long? Total { get; set; }

}