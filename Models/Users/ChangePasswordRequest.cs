using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the ChangePasswordRequest payload.</summary>
public class ChangePasswordRequest
{
    /// <summary>Gets or sets <c>current_password</c>.</summary>
    [JsonPropertyName("current_password")]
    public required string CurrentPassword { get; set; }

    /// <summary>Gets or sets <c>new_password</c>.</summary>
    [JsonPropertyName("new_password")]
    public required string NewPassword { get; set; }

}