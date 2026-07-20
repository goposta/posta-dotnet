using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the RegisterResponseDataUser payload.</summary>
public class RegisterResponseDataUser
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>role</c>.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

}