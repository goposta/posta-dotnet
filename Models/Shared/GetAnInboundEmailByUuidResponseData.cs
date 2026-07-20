using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetAnInboundEmailByUuidResponseData payload.</summary>
public class GetAnInboundEmailByUuidResponseData
{
    /// <summary>Gets or sets <c>attachments_json</c>.</summary>
    [JsonPropertyName("attachments_json")]
    public string? AttachmentsJson { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>domain_id</c>.</summary>
    [JsonPropertyName("domain_id")]
    public int? DomainId { get; set; }

    /// <summary>Gets or sets <c>error_message</c>.</summary>
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; set; }

    /// <summary>Gets or sets <c>forwarded_at</c>.</summary>
    [JsonPropertyName("forwarded_at")]
    public DateTimeOffset? ForwardedAt { get; set; }

    /// <summary>Gets or sets <c>headers_json</c>.</summary>
    [JsonPropertyName("headers_json")]
    public string? HeadersJson { get; set; }

    /// <summary>Gets or sets <c>html_body</c>.</summary>
    [JsonPropertyName("html_body")]
    public string? HtmlBody { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>message_id</c>.</summary>
    [JsonPropertyName("message_id")]
    public string? MessageId { get; set; }

    /// <summary>Gets or sets <c>raw_storage_key</c>.</summary>
    [JsonPropertyName("raw_storage_key")]
    public string? RawStorageKey { get; set; }

    /// <summary>Gets or sets <c>received_at</c>.</summary>
    [JsonPropertyName("received_at")]
    public DateTimeOffset? ReceivedAt { get; set; }

    /// <summary>Gets or sets <c>recipients</c>.</summary>
    [JsonPropertyName("recipients")]
    public IReadOnlyList<string>? Recipients { get; set; }

    /// <summary>Gets or sets <c>retry_count</c>.</summary>
    [JsonPropertyName("retry_count")]
    public int? RetryCount { get; set; }

    /// <summary>Gets or sets <c>sender</c>.</summary>
    [JsonPropertyName("sender")]
    public string? Sender { get; set; }

    /// <summary>Gets or sets <c>size</c>.</summary>
    [JsonPropertyName("size")]
    public long? Size { get; set; }

    /// <summary>Gets or sets <c>source</c>.</summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

    /// <summary>Gets or sets <c>spam_score</c>.</summary>
    [JsonPropertyName("spam_score")]
    public double? SpamScore { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>subject</c>.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Gets or sets <c>text_body</c>.</summary>
    [JsonPropertyName("text_body")]
    public string? TextBody { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>uuid</c>.</summary>
    [JsonPropertyName("uuid")]
    public string? Uuid { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}