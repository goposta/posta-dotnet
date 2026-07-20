using System.Text.Json.Serialization;

namespace Posta.Models.Auth;

/// <summary>Represents the ResetPasswordRequest payload.</summary>
public class ResetPasswordRequest
{
    /// <summary>Gets or sets <c>new_password</c>.</summary>
    [JsonPropertyName("new_password")]
    public required string NewPassword { get; set; }

    /// <summary>Gets or sets <c>token</c>.</summary>
    [JsonPropertyName("token")]
    public required string Token { get; set; }

}