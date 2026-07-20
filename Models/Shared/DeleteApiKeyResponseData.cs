using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DeleteApiKeyResponseData payload.</summary>
public class DeleteApiKeyResponseData
{
    /// <summary>Gets or sets <c>message</c>.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

}