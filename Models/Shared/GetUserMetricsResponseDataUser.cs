using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetUserMetricsResponseDataUser payload.</summary>
public class GetUserMetricsResponseDataUser
{
    /// <summary>Gets or sets <c>Active</c>.</summary>
    [JsonPropertyName("Active")]
    public bool? Active { get; set; }

    /// <summary>Gets or sets <c>AuthMethod</c>.</summary>
    [JsonPropertyName("AuthMethod")]
    public string? AuthMethod { get; set; }

    /// <summary>Gets or sets <c>AvatarUrl</c>.</summary>
    [JsonPropertyName("AvatarUrl")]
    public string? AvatarUrl { get; set; }

    /// <summary>Gets or sets <c>CreatedAt</c>.</summary>
    [JsonPropertyName("CreatedAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>Email</c>.</summary>
    [JsonPropertyName("Email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>EmailVerifiedAt</c>.</summary>
    [JsonPropertyName("EmailVerifiedAt")]
    public DateTimeOffset? EmailVerifiedAt { get; set; }

    /// <summary>Gets or sets <c>Id</c>.</summary>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>LastLoginAt</c>.</summary>
    [JsonPropertyName("LastLoginAt")]
    public DateTimeOffset? LastLoginAt { get; set; }

    /// <summary>Gets or sets <c>MigratedAt</c>.</summary>
    [JsonPropertyName("MigratedAt")]
    public DateTimeOffset? MigratedAt { get; set; }

    /// <summary>Gets or sets <c>MigrationError</c>.</summary>
    [JsonPropertyName("MigrationError")]
    public string? MigrationError { get; set; }

    /// <summary>Gets or sets <c>Name</c>.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>PersonalWorkspaceId</c>.</summary>
    [JsonPropertyName("PersonalWorkspaceId")]
    public int? PersonalWorkspaceId { get; set; }

    /// <summary>Gets or sets <c>PlanId</c>.</summary>
    [JsonPropertyName("PlanId")]
    public int? PlanId { get; set; }

    /// <summary>Gets or sets <c>RequireVerifiedDomain</c>.</summary>
    [JsonPropertyName("RequireVerifiedDomain")]
    public bool? RequireVerifiedDomain { get; set; }

    /// <summary>Gets or sets <c>Role</c>.</summary>
    [JsonPropertyName("Role")]
    public string? Role { get; set; }

    /// <summary>Gets or sets <c>ScheduledDeletionAt</c>.</summary>
    [JsonPropertyName("ScheduledDeletionAt")]
    public DateTimeOffset? ScheduledDeletionAt { get; set; }

    /// <summary>Gets or sets <c>TwoFactorEnabled</c>.</summary>
    [JsonPropertyName("TwoFactorEnabled")]
    public bool? TwoFactorEnabled { get; set; }

}