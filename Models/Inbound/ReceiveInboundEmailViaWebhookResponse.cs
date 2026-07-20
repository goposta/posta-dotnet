using System.Text.Json.Serialization;

namespace Posta.Models.Inbound;

/// <summary>Represents the ReceiveInboundEmailViaWebhookResponse payload.</summary>
public class ReceiveInboundEmailViaWebhookResponse
{
    /// <summary>Gets or sets <c>accepted</c>.</summary>
    [JsonPropertyName("accepted")]
    public bool? Accepted { get; set; }

    /// <summary>Gets or sets <c>inbound_id</c>.</summary>
    [JsonPropertyName("inbound_id")]
    public string? InboundId { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

}