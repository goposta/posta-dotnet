using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the CreateANewUserRequest payload.</summary>
public class CreateANewUserRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>password</c>.</summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }

    /// <summary>Gets or sets <c>role</c>.</summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }

}