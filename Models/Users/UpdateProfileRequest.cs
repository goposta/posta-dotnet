using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the UpdateProfileRequest payload.</summary>
public class UpdateProfileRequest
{
    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Gets or sets <c>require_verified_domain</c>.</summary>
    [JsonPropertyName("require_verified_domain")]
    public bool? RequireVerifiedDomain { get; set; }

}