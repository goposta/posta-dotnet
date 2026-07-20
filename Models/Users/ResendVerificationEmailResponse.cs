using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the ResendVerificationEmailResponse payload.</summary>
public class ResendVerificationEmailResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.ResendVerificationEmailResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}