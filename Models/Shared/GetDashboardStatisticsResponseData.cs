using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetDashboardStatisticsResponseData payload.</summary>
public class GetDashboardStatisticsResponseData
{
    /// <summary>Gets or sets <c>active_api_keys</c>.</summary>
    [JsonPropertyName("active_api_keys")]
    public long? ActiveApiKeys { get; set; }

    /// <summary>Gets or sets <c>daily_volume</c>.</summary>
    [JsonPropertyName("daily_volume")]
    public IReadOnlyList<GetDashboardStatisticsResponseDataDailyVolumeItem>? DailyVolume { get; set; }

    /// <summary>Gets or sets <c>failed_emails</c>.</summary>
    [JsonPropertyName("failed_emails")]
    public long? FailedEmails { get; set; }

    /// <summary>Gets or sets <c>failed_inbound</c>.</summary>
    [JsonPropertyName("failed_inbound")]
    public long? FailedInbound { get; set; }

    /// <summary>Gets or sets <c>failure_rate</c>.</summary>
    [JsonPropertyName("failure_rate")]
    public double? FailureRate { get; set; }

    /// <summary>Gets or sets <c>forwarded_inbound</c>.</summary>
    [JsonPropertyName("forwarded_inbound")]
    public long? ForwardedInbound { get; set; }

    /// <summary>Gets or sets <c>processing_emails</c>.</summary>
    [JsonPropertyName("processing_emails")]
    public long? ProcessingEmails { get; set; }

    /// <summary>Gets or sets <c>queued_emails</c>.</summary>
    [JsonPropertyName("queued_emails")]
    public long? QueuedEmails { get; set; }

    /// <summary>Gets or sets <c>sent_emails</c>.</summary>
    [JsonPropertyName("sent_emails")]
    public long? SentEmails { get; set; }

    /// <summary>Gets or sets <c>suppressed_emails</c>.</summary>
    [JsonPropertyName("suppressed_emails")]
    public long? SuppressedEmails { get; set; }

    /// <summary>Gets or sets <c>total_api_keys</c>.</summary>
    [JsonPropertyName("total_api_keys")]
    public long? TotalApiKeys { get; set; }

    /// <summary>Gets or sets <c>total_bounces</c>.</summary>
    [JsonPropertyName("total_bounces")]
    public long? TotalBounces { get; set; }

    /// <summary>Gets or sets <c>total_contacts</c>.</summary>
    [JsonPropertyName("total_contacts")]
    public long? TotalContacts { get; set; }

    /// <summary>Gets or sets <c>total_domains</c>.</summary>
    [JsonPropertyName("total_domains")]
    public long? TotalDomains { get; set; }

    /// <summary>Gets or sets <c>total_emails</c>.</summary>
    [JsonPropertyName("total_emails")]
    public long? TotalEmails { get; set; }

    /// <summary>Gets or sets <c>total_inbound</c>.</summary>
    [JsonPropertyName("total_inbound")]
    public long? TotalInbound { get; set; }

    /// <summary>Gets or sets <c>total_smtp_servers</c>.</summary>
    [JsonPropertyName("total_smtp_servers")]
    public long? TotalSmtpServers { get; set; }

    /// <summary>Gets or sets <c>total_suppressions</c>.</summary>
    [JsonPropertyName("total_suppressions")]
    public long? TotalSuppressions { get; set; }

    /// <summary>Gets or sets <c>total_webhooks</c>.</summary>
    [JsonPropertyName("total_webhooks")]
    public long? TotalWebhooks { get; set; }

    /// <summary>Gets or sets <c>webhook_deliveries</c>.</summary>
    [JsonPropertyName("webhook_deliveries")]
    public GetDashboardStatisticsResponseDataWebhookDeliveries? WebhookDeliveries { get; set; }

}