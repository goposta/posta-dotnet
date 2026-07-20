using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the UpdateProfileResponseData payload.</summary>
public class UpdateProfileResponseData
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>email_verification_required</c>.</summary>
    [JsonPropertyName("email_verification_required")]
    public bool? EmailVerificationRequired { get; set; }

    /// <summary>Gets or sets <c>email_verified_at</c>.</summary>
    [JsonPropertyName("email_verified_at")]
    public DateTimeOffset? EmailVerifiedAt { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>require_verified_domain</c>.</summary>
    [JsonPropertyName("require_verified_domain")]
    public bool? RequireVerifiedDomain { get; set; }

    /// <summary>Gets or sets <c>role</c>.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Gets or sets <c>scheduled_deletion_at</c>.</summary>
    [JsonPropertyName("scheduled_deletion_at")]
    public DateTimeOffset? ScheduledDeletionAt { get; set; }

    /// <summary>Gets or sets <c>two_factor_enabled</c>.</summary>
    [JsonPropertyName("two_factor_enabled")]
    public bool? TwoFactorEnabled { get; set; }

}