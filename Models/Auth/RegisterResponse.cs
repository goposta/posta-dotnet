using System.Text.Json.Serialization;

namespace Posta.Models.Auth;

/// <summary>Represents the RegisterResponse payload.</summary>
public class RegisterResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.RegisterResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}