using System.Text.Json.Serialization;

namespace Posta.Models.Auth;

/// <summary>Represents the RequestPasswordResetRequest payload.</summary>
public class RequestPasswordResetRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

}