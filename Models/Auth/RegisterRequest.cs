using System.Text.Json.Serialization;

namespace Posta.Models.Auth;

/// <summary>Represents the RegisterRequest payload.</summary>
public class RegisterRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Gets or sets <c>password</c>.</summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }

}