using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PlatformMetricsResponseData payload.</summary>
public class PlatformMetricsResponseData
{
    /// <summary>Gets or sets <c>ActiveApiKeys</c>.</summary>
    [JsonPropertyName("ActiveApiKeys")]
    public long? ActiveApiKeys { get; set; }

    /// <summary>Gets or sets <c>ActiveSessions</c>.</summary>
    [JsonPropertyName("ActiveSessions")]
    public long? ActiveSessions { get; set; }

    /// <summary>Gets or sets <c>ActiveWorkers</c>.</summary>
    [JsonPropertyName("ActiveWorkers")]
    public int? ActiveWorkers { get; set; }

    /// <summary>Gets or sets <c>CurrentGoroutines</c>.</summary>
    [JsonPropertyName("CurrentGoroutines")]
    public int? CurrentGoroutines { get; set; }

    /// <summary>Gets or sets <c>CurrentMemoryUsage</c>.</summary>
    [JsonPropertyName("CurrentMemoryUsage")]
    public long? CurrentMemoryUsage { get; set; }

    /// <summary>Gets or sets <c>FailedEmails</c>.</summary>
    [JsonPropertyName("FailedEmails")]
    public long? FailedEmails { get; set; }

    /// <summary>Gets or sets <c>FailedInbound</c>.</summary>
    [JsonPropertyName("FailedInbound")]
    public long? FailedInbound { get; set; }

    /// <summary>Gets or sets <c>FailedLoginsLast24h</c>.</summary>
    [JsonPropertyName("FailedLoginsLast24h")]
    public long? FailedLoginsLast24h { get; set; }

    /// <summary>Gets or sets <c>FailureRate</c>.</summary>
    [JsonPropertyName("FailureRate")]
    public double? FailureRate { get; set; }

    /// <summary>Gets or sets <c>ForwardedInbound</c>.</summary>
    [JsonPropertyName("ForwardedInbound")]
    public long? ForwardedInbound { get; set; }

    /// <summary>Gets or sets <c>ProcessingEmails</c>.</summary>
    [JsonPropertyName("ProcessingEmails")]
    public long? ProcessingEmails { get; set; }

    /// <summary>Gets or sets <c>QueuedEmails</c>.</summary>
    [JsonPropertyName("QueuedEmails")]
    public long? QueuedEmails { get; set; }

    /// <summary>Gets or sets <c>ReceivedInbound</c>.</summary>
    [JsonPropertyName("ReceivedInbound")]
    public long? ReceivedInbound { get; set; }

    /// <summary>Gets or sets <c>RejectedInbound</c>.</summary>
    [JsonPropertyName("RejectedInbound")]
    public long? RejectedInbound { get; set; }

    /// <summary>Gets or sets <c>SentEmails</c>.</summary>
    [JsonPropertyName("SentEmails")]
    public long? SentEmails { get; set; }

    /// <summary>Gets or sets <c>ServerUptimeSeconds</c>.</summary>
    [JsonPropertyName("ServerUptimeSeconds")]
    public double? ServerUptimeSeconds { get; set; }

    /// <summary>Gets or sets <c>SharedSmtpServers</c>.</summary>
    [JsonPropertyName("SharedSmtpServers")]
    public long? SharedSmtpServers { get; set; }

    /// <summary>Gets or sets <c>SuppressedEmails</c>.</summary>
    [JsonPropertyName("SuppressedEmails")]
    public long? SuppressedEmails { get; set; }

    /// <summary>Gets or sets <c>TotalApiKeys</c>.</summary>
    [JsonPropertyName("TotalApiKeys")]
    public long? TotalApiKeys { get; set; }

    /// <summary>Gets or sets <c>TotalBounces</c>.</summary>
    [JsonPropertyName("TotalBounces")]
    public long? TotalBounces { get; set; }

    /// <summary>Gets or sets <c>TotalDomains</c>.</summary>
    [JsonPropertyName("TotalDomains")]
    public long? TotalDomains { get; set; }

    /// <summary>Gets or sets <c>TotalEmails</c>.</summary>
    [JsonPropertyName("TotalEmails")]
    public long? TotalEmails { get; set; }

    /// <summary>Gets or sets <c>TotalInbound</c>.</summary>
    [JsonPropertyName("TotalInbound")]
    public long? TotalInbound { get; set; }

    /// <summary>Gets or sets <c>TotalSuppressions</c>.</summary>
    [JsonPropertyName("TotalSuppressions")]
    public long? TotalSuppressions { get; set; }

    /// <summary>Gets or sets <c>TotalUsers</c>.</summary>
    [JsonPropertyName("TotalUsers")]
    public long? TotalUsers { get; set; }

    /// <summary>Gets or sets <c>TotalWorkspaces</c>.</summary>
    [JsonPropertyName("TotalWorkspaces")]
    public long? TotalWorkspaces { get; set; }

    /// <summary>Gets or sets <c>TwoFactorAdoptionRate</c>.</summary>
    [JsonPropertyName("TwoFactorAdoptionRate")]
    public double? TwoFactorAdoptionRate { get; set; }

    /// <summary>Gets or sets <c>TwoFactorUsers</c>.</summary>
    [JsonPropertyName("TwoFactorUsers")]
    public long? TwoFactorUsers { get; set; }

    /// <summary>Gets or sets <c>UsersMigrationFailed</c>.</summary>
    [JsonPropertyName("UsersMigrationFailed")]
    public long? UsersMigrationFailed { get; set; }

    /// <summary>Gets or sets <c>UsersUnmigrated</c>.</summary>
    [JsonPropertyName("UsersUnmigrated")]
    public long? UsersUnmigrated { get; set; }

    /// <summary>Gets or sets <c>WebhookDeliveries</c>.</summary>
    [JsonPropertyName("WebhookDeliveries")]
    public PlatformMetricsResponseDataWebhookDeliveries? WebhookDeliveries { get; set; }

}