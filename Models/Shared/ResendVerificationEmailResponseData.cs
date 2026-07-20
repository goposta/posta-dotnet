using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ResendVerificationEmailResponseData payload.</summary>
public class ResendVerificationEmailResponseData
{
    /// <summary>Gets or sets <c>message</c>.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

}