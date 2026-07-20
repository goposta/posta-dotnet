using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetUserMetricsResponseData payload.</summary>
public class GetUserMetricsResponseData
{
    /// <summary>Gets or sets <c>ActiveApiKeys</c>.</summary>
    [JsonPropertyName("ActiveApiKeys")]
    public long? ActiveApiKeys { get; set; }

    /// <summary>Gets or sets <c>FailedEmails</c>.</summary>
    [JsonPropertyName("FailedEmails")]
    public long? FailedEmails { get; set; }

    /// <summary>Gets or sets <c>FailedInbound</c>.</summary>
    [JsonPropertyName("FailedInbound")]
    public long? FailedInbound { get; set; }

    /// <summary>Gets or sets <c>FailureRate</c>.</summary>
    [JsonPropertyName("FailureRate")]
    public double? FailureRate { get; set; }

    /// <summary>Gets or sets <c>ForwardedInbound</c>.</summary>
    [JsonPropertyName("ForwardedInbound")]
    public long? ForwardedInbound { get; set; }

    /// <summary>Gets or sets <c>SentEmails</c>.</summary>
    [JsonPropertyName("SentEmails")]
    public long? SentEmails { get; set; }

    /// <summary>Gets or sets <c>SuppressedEmails</c>.</summary>
    [JsonPropertyName("SuppressedEmails")]
    public long? SuppressedEmails { get; set; }

    /// <summary>Gets or sets <c>TotalApiKeys</c>.</summary>
    [JsonPropertyName("TotalApiKeys")]
    public long? TotalApiKeys { get; set; }

    /// <summary>Gets or sets <c>TotalBounces</c>.</summary>
    [JsonPropertyName("TotalBounces")]
    public long? TotalBounces { get; set; }

    /// <summary>Gets or sets <c>TotalContacts</c>.</summary>
    [JsonPropertyName("TotalContacts")]
    public long? TotalContacts { get; set; }

    /// <summary>Gets or sets <c>TotalDomains</c>.</summary>
    [JsonPropertyName("TotalDomains")]
    public long? TotalDomains { get; set; }

    /// <summary>Gets or sets <c>TotalEmails</c>.</summary>
    [JsonPropertyName("TotalEmails")]
    public long? TotalEmails { get; set; }

    /// <summary>Gets or sets <c>TotalInbound</c>.</summary>
    [JsonPropertyName("TotalInbound")]
    public long? TotalInbound { get; set; }

    /// <summary>Gets or sets <c>TotalSmtpServers</c>.</summary>
    [JsonPropertyName("TotalSmtpServers")]
    public long? TotalSmtpServers { get; set; }

    /// <summary>Gets or sets <c>TotalSuppressions</c>.</summary>
    [JsonPropertyName("TotalSuppressions")]
    public long? TotalSuppressions { get; set; }

    /// <summary>Gets or sets <c>User</c>.</summary>
    [JsonPropertyName("User")]
    public GetUserMetricsResponseDataUser? User { get; set; }

    /// <summary>Gets or sets <c>WebhookDeliveries</c>.</summary>
    [JsonPropertyName("WebhookDeliveries")]
    public GetUserMetricsResponseDataWebhookDeliveries? WebhookDeliveries { get; set; }

}