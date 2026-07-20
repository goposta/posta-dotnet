using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Inbound;

/// <summary>Represents the ReceiveInboundEmailViaWebhookRequest payload.</summary>
public class ReceiveInboundEmailViaWebhookRequest
{
    /// <summary>Gets or sets <c>attachments</c>.</summary>
    [JsonPropertyName("attachments")]
    public IReadOnlyList<Shared.ReceiveInboundEmailViaWebhookRequestAttachmentsItem>? Attachments { get; set; }

    /// <summary>Gets or sets <c>from</c>.</summary>
    [JsonPropertyName("from")]
    public required string From { get; set; }

    /// <summary>Gets or sets <c>headers</c>.</summary>
    [JsonPropertyName("headers")]
    public IReadOnlyDictionary<string, JsonElement>? Headers { get; set; }

    /// <summary>Gets or sets <c>html</c>.</summary>
    [JsonPropertyName("html")]
    public string? Html { get; set; }

    /// <summary>Gets or sets <c>message_id</c>.</summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>Gets or sets <c>raw</c>.</summary>
    [JsonPropertyName("raw")]
    public string? Raw { get; set; }

    /// <summary>Gets or sets <c>spam_score</c>.</summary>
    [JsonPropertyName("spam_score")]
    public double? SpamScore { get; set; }

    /// <summary>Gets or sets <c>subject</c>.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Gets or sets <c>text</c>.</summary>
    [JsonPropertyName("text")]
    public string? Text { get; set; }

    /// <summary>Gets or sets <c>to</c>.</summary>
    [JsonPropertyName("to")]
    public required IReadOnlyList<string> To { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Inbound-Secret</c> header parameter.</summary>
    [JsonIgnore]
    public required string XPostaInboundSecret { get; set; }

}