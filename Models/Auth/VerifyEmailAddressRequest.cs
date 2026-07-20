using System.Text.Json.Serialization;

namespace Posta.Models.Auth;

/// <summary>Represents the VerifyEmailAddressRequest payload.</summary>
public class VerifyEmailAddressRequest
{
    /// <summary>Gets or sets the <c>token</c> query parameter.</summary>
    [JsonIgnore]
    public required string Token { get; set; }

}