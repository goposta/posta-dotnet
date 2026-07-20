using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the ChangePasswordResponse payload.</summary>
public class ChangePasswordResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.ChangePasswordResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}