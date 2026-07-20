using System.Text.Json.Serialization;

namespace Posta.Models.Auth;

/// <summary>Represents the LoginRequest payload.</summary>
public class LoginRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Gets or sets <c>password</c>.</summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }

    /// <summary>Gets or sets <c>two_factor_code</c>.</summary>
    [JsonPropertyName("two_factor_code")]
    public string? TwoFactorCode { get; set; }

}