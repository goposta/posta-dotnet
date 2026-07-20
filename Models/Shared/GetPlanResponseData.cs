using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetPlanResponseData payload.</summary>
public class GetPlanResponseData
{
    /// <summary>Gets or sets <c>CreatedAt</c>.</summary>
    [JsonPropertyName("CreatedAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>DailyRateLimit</c>.</summary>
    [JsonPropertyName("DailyRateLimit")]
    public int? DailyRateLimit { get; set; }

    /// <summary>Gets or sets <c>Description</c>.</summary>
    [JsonPropertyName("Description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>EmailLogRetentionDays</c>.</summary>
    [JsonPropertyName("EmailLogRetentionDays")]
    public int? EmailLogRetentionDays { get; set; }

    /// <summary>Gets or sets <c>HourlyRateLimit</c>.</summary>
    [JsonPropertyName("HourlyRateLimit")]
    public int? HourlyRateLimit { get; set; }

    /// <summary>Gets or sets <c>Id</c>.</summary>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>IsActive</c>.</summary>
    [JsonPropertyName("IsActive")]
    public bool? IsActive { get; set; }

    /// <summary>Gets or sets <c>IsDefault</c>.</summary>
    [JsonPropertyName("IsDefault")]
    public bool? IsDefault { get; set; }

    /// <summary>Gets or sets <c>MaxApiKeys</c>.</summary>
    [JsonPropertyName("MaxApiKeys")]
    public int? MaxApiKeys { get; set; }

    /// <summary>Gets or sets <c>MaxAttachmentSizeMb</c>.</summary>
    [JsonPropertyName("MaxAttachmentSizeMb")]
    public int? MaxAttachmentSizeMb { get; set; }

    /// <summary>Gets or sets <c>MaxBatchSize</c>.</summary>
    [JsonPropertyName("MaxBatchSize")]
    public int? MaxBatchSize { get; set; }

    /// <summary>Gets or sets <c>MaxDomains</c>.</summary>
    [JsonPropertyName("MaxDomains")]
    public int? MaxDomains { get; set; }

    /// <summary>Gets or sets <c>MaxSmtpServers</c>.</summary>
    [JsonPropertyName("MaxSmtpServers")]
    public int? MaxSmtpServers { get; set; }

    /// <summary>Gets or sets <c>MaxWorkspaces</c>.</summary>
    [JsonPropertyName("MaxWorkspaces")]
    public int? MaxWorkspaces { get; set; }

    /// <summary>Gets or sets <c>Name</c>.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>UpdatedAt</c>.</summary>
    [JsonPropertyName("UpdatedAt")]
    public DateTimeOffset? UpdatedAt { get; set; }

}