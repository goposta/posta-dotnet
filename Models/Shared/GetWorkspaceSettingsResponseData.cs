using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetWorkspaceSettingsResponseData payload.</summary>
public class GetWorkspaceSettingsResponseData
{
    /// <summary>Gets or sets <c>api_key_expiry_days</c>.</summary>
    [JsonPropertyName("api_key_expiry_days")]
    public int? ApiKeyExpiryDays { get; set; }

    /// <summary>Gets or sets <c>bounce_auto_suppress</c>.</summary>
    [JsonPropertyName("bounce_auto_suppress")]
    public bool? BounceAutoSuppress { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>default_sender_email</c>.</summary>
    [JsonPropertyName("default_sender_email")]
    public string? DefaultSenderEmail { get; set; }

    /// <summary>Gets or sets <c>default_sender_name</c>.</summary>
    [JsonPropertyName("default_sender_name")]
    public string? DefaultSenderName { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>require_verified_domain</c>.</summary>
    [JsonPropertyName("require_verified_domain")]
    public bool? RequireVerifiedDomain { get; set; }

    /// <summary>Gets or sets <c>timezone</c>.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>Gets or sets <c>updated_at</c>.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>Gets or sets <c>webhook_retry_count</c>.</summary>
    [JsonPropertyName("webhook_retry_count")]
    public int? WebhookRetryCount { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}