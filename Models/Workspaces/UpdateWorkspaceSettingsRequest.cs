using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the UpdateWorkspaceSettingsRequest payload.</summary>
public class UpdateWorkspaceSettingsRequest
{
    /// <summary>Gets or sets <c>api_key_expiry_days</c>.</summary>
    [JsonPropertyName("api_key_expiry_days")]
    public int? ApiKeyExpiryDays { get; set; }

    /// <summary>Gets or sets <c>bounce_auto_suppress</c>.</summary>
    [JsonPropertyName("bounce_auto_suppress")]
    public bool? BounceAutoSuppress { get; set; }

    /// <summary>Gets or sets <c>default_sender_email</c>.</summary>
    [JsonPropertyName("default_sender_email")]
    public string? DefaultSenderEmail { get; set; }

    /// <summary>Gets or sets <c>default_sender_name</c>.</summary>
    [JsonPropertyName("default_sender_name")]
    public string? DefaultSenderName { get; set; }

    /// <summary>Gets or sets <c>require_verified_domain</c>.</summary>
    [JsonPropertyName("require_verified_domain")]
    public bool? RequireVerifiedDomain { get; set; }

    /// <summary>Gets or sets <c>timezone</c>.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Gets or sets <c>webhook_retry_count</c>.</summary>
    [JsonPropertyName("webhook_retry_count")]
    public int? WebhookRetryCount { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}