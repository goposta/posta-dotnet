using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the UpdateUserSettingsRequest payload.</summary>
public class UpdateUserSettingsRequest
{
    /// <summary>Gets or sets <c>api_key_expiry_days</c>.</summary>
    [JsonPropertyName("api_key_expiry_days")]
    public int? ApiKeyExpiryDays { get; set; }

    /// <summary>Gets or sets <c>bounce_auto_suppress</c>.</summary>
    [JsonPropertyName("bounce_auto_suppress")]
    public bool? BounceAutoSuppress { get; set; }

    /// <summary>Gets or sets <c>daily_report</c>.</summary>
    [JsonPropertyName("daily_report")]
    public bool? DailyReport { get; set; }

    /// <summary>Gets or sets <c>default_language</c>.</summary>
    [JsonPropertyName("default_language")]
    public string? DefaultLanguage { get; set; }

    /// <summary>Gets or sets <c>default_sender_email</c>.</summary>
    [JsonPropertyName("default_sender_email")]
    public string? DefaultSenderEmail { get; set; }

    /// <summary>Gets or sets <c>default_sender_name</c>.</summary>
    [JsonPropertyName("default_sender_name")]
    public string? DefaultSenderName { get; set; }

    /// <summary>Gets or sets <c>default_template_id</c>.</summary>
    [JsonPropertyName("default_template_id")]
    public int? DefaultTemplateId { get; set; }

    /// <summary>Gets or sets <c>email_notifications</c>.</summary>
    [JsonPropertyName("email_notifications")]
    public bool? EmailNotifications { get; set; }

    /// <summary>Gets or sets <c>notification_email</c>.</summary>
    [JsonPropertyName("notification_email")]
    public string? NotificationEmail { get; set; }

    /// <summary>Gets or sets <c>notify_api_key_expiry</c>.</summary>
    [JsonPropertyName("notify_api_key_expiry")]
    public bool? NotifyApiKeyExpiry { get; set; }

    /// <summary>Gets or sets <c>notify_bounce_alerts</c>.</summary>
    [JsonPropertyName("notify_bounce_alerts")]
    public bool? NotifyBounceAlerts { get; set; }

    /// <summary>Gets or sets <c>notify_workspace_activity</c>.</summary>
    [JsonPropertyName("notify_workspace_activity")]
    public bool? NotifyWorkspaceActivity { get; set; }

    /// <summary>Gets or sets <c>timezone</c>.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Gets or sets <c>webhook_retry_count</c>.</summary>
    [JsonPropertyName("webhook_retry_count")]
    public int? WebhookRetryCount { get; set; }

}