using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DeliverabilityByProviderResponseDataProvidersItem payload.</summary>
public class DeliverabilityByProviderResponseDataProvidersItem
{
    /// <summary>Gets or sets <c>bounced</c>.</summary>
    [JsonPropertyName("bounced")]
    public long? Bounced { get; set; }

    /// <summary>Gets or sets <c>delivery_rate</c>.</summary>
    [JsonPropertyName("delivery_rate")]
    public double? DeliveryRate { get; set; }

    /// <summary>Gets or sets <c>failed</c>.</summary>
    [JsonPropertyName("failed")]
    public long? Failed { get; set; }

    /// <summary>Gets or sets <c>provider</c>.</summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>Gets or sets <c>sent</c>.</summary>
    [JsonPropertyName("sent")]
    public long? Sent { get; set; }

    /// <summary>Gets or sets <c>total</c>.</summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }

}