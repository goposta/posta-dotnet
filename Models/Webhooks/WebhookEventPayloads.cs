using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

public sealed class WebhookEvent
{
    [JsonPropertyName("event")] public string? Event { get; set; }
    [JsonPropertyName("email_id")] public string? EmailId { get; set; }
    [JsonPropertyName("timestamp")] public DateTimeOffset? Timestamp { get; set; }
}

public sealed class CampaignWebhookEvent
{
    [JsonPropertyName("event")] public string? Event { get; set; }
    [JsonPropertyName("campaign_id")] public uint? CampaignId { get; set; }
    [JsonPropertyName("name")] public string? Name { get; set; }
    [JsonPropertyName("timestamp")] public DateTimeOffset? Timestamp { get; set; }
}

public sealed class ComplaintWebhookEvent
{
    [JsonPropertyName("event")] public string? Event { get; set; }
    [JsonPropertyName("email_uuid")] public string? EmailUuid { get; set; }
    [JsonPropertyName("email")] public string? Email { get; set; }
    [JsonPropertyName("timestamp")] public DateTimeOffset? Timestamp { get; set; }
}

public sealed class UnsubscribeWebhookEvent
{
    [JsonPropertyName("event")] public string? Event { get; set; }
    [JsonPropertyName("email_uuid")] public string? EmailUuid { get; set; }
    [JsonPropertyName("email")] public string? Email { get; set; }
    [JsonPropertyName("list_id")] public uint? ListId { get; set; }
    [JsonPropertyName("timestamp")] public DateTimeOffset? Timestamp { get; set; }
}

public sealed class InboundWebhookEvent
{
    [JsonPropertyName("event")] public string? Event { get; set; }
    [JsonPropertyName("timestamp")] public DateTimeOffset? Timestamp { get; set; }
    [JsonPropertyName("inbound_id")] public string? InboundId { get; set; }
    [JsonPropertyName("from")] public string? From { get; set; }
    [JsonPropertyName("to")] public IReadOnlyList<string>? To { get; set; }
    [JsonPropertyName("subject")] public string? Subject { get; set; }
    [JsonPropertyName("text_body")] public string? TextBody { get; set; }
    [JsonPropertyName("html_body")] public string? HtmlBody { get; set; }
    [JsonPropertyName("headers")] public IReadOnlyDictionary<string, string>? Headers { get; set; }
    [JsonPropertyName("attachments")] public IReadOnlyList<InboundWebhookAttachment>? Attachments { get; set; }
    [JsonPropertyName("size")] public long? Size { get; set; }
    [JsonPropertyName("message_id")] public string? MessageId { get; set; }
    [JsonPropertyName("source")] public string? Source { get; set; }
    [JsonPropertyName("received_at")] public DateTimeOffset? ReceivedAt { get; set; }
}

public sealed class InboundWebhookAttachment
{
    [JsonPropertyName("filename")] public string? Filename { get; set; }
    [JsonPropertyName("content_type")] public string? ContentType { get; set; }
    [JsonPropertyName("size")] public long? Size { get; set; }
    [JsonPropertyName("url")] public string? Url { get; set; }
}
