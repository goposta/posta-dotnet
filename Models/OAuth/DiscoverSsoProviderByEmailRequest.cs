using System.Text.Json.Serialization;

namespace Posta.Models.OAuth;

/// <summary>Represents the DiscoverSsoProviderByEmailRequest payload.</summary>
public class DiscoverSsoProviderByEmailRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

}