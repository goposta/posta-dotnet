using System.Text.Json.Serialization;

namespace Posta.Models.Auth;

/// <summary>Represents the LoginResponse payload.</summary>
public class LoginResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.LoginResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}