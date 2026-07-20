using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the RegisterResponseData payload.</summary>
public class RegisterResponseData
{
    /// <summary>Gets or sets <c>token</c>.</summary>
    [JsonPropertyName("token")]
    public string? Token { get; set; }

    /// <summary>Gets or sets <c>user</c>.</summary>
    [JsonPropertyName("user")]
    public RegisterResponseDataUser? User { get; set; }

}