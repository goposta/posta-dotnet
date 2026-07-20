using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ReceiveInboundEmailViaWebhookRequestAttachmentsItem payload.</summary>
public class ReceiveInboundEmailViaWebhookRequestAttachmentsItem
{
    /// <summary>Gets or sets <c>content</c>.</summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>Gets or sets <c>content_type</c>.</summary>
    [JsonPropertyName("content_type")]
    public string? ContentType { get; set; }

    /// <summary>Gets or sets <c>filename</c>.</summary>
    [JsonPropertyName("filename")]
    public string? Filename { get; set; }

}