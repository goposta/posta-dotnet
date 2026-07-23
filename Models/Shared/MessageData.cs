using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents a response containing a message.</summary>
public class MessageData
{
    /// <summary>Gets or sets the response message.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
