using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the RevokeApiKeyResponseData payload.</summary>
public class RevokeApiKeyResponseData
{
    /// <summary>Gets or sets <c>message</c>.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

}