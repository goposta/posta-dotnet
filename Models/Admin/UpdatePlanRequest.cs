using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the UpdatePlanRequest payload.</summary>
public class UpdatePlanRequest
{
    /// <summary>Gets or sets <c>daily_rate_limit</c>.</summary>
    [JsonPropertyName("daily_rate_limit")]
    public int? DailyRateLimit { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>email_log_retention_days</c>.</summary>
    [JsonPropertyName("email_log_retention_days")]
    public int? EmailLogRetentionDays { get; set; }

    /// <summary>Gets or sets <c>hourly_rate_limit</c>.</summary>
    [JsonPropertyName("hourly_rate_limit")]
    public int? HourlyRateLimit { get; set; }

    /// <summary>Gets or sets <c>is_active</c>.</summary>
    [JsonPropertyName("is_active")]
    public bool? IsActive { get; set; }

    /// <summary>Gets or sets <c>is_default</c>.</summary>
    [JsonPropertyName("is_default")]
    public bool? IsDefault { get; set; }

    /// <summary>Gets or sets <c>max_api_keys</c>.</summary>
    [JsonPropertyName("max_api_keys")]
    public int? MaxApiKeys { get; set; }

    /// <summary>Gets or sets <c>max_attachment_size_mb</c>.</summary>
    [JsonPropertyName("max_attachment_size_mb")]
    public int? MaxAttachmentSizeMb { get; set; }

    /// <summary>Gets or sets <c>max_batch_size</c>.</summary>
    [JsonPropertyName("max_batch_size")]
    public int? MaxBatchSize { get; set; }

    /// <summary>Gets or sets <c>max_domains</c>.</summary>
    [JsonPropertyName("max_domains")]
    public int? MaxDomains { get; set; }

    /// <summary>Gets or sets <c>max_smtp_servers</c>.</summary>
    [JsonPropertyName("max_smtp_servers")]
    public int? MaxSmtpServers { get; set; }

    /// <summary>Gets or sets <c>max_workspaces</c>.</summary>
    [JsonPropertyName("max_workspaces")]
    public int? MaxWorkspaces { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}