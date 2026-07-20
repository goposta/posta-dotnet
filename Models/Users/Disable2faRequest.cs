using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the Disable2faRequest payload.</summary>
public class Disable2faRequest
{
    /// <summary>Gets or sets <c>code</c>.</summary>
    [JsonPropertyName("code")]
    public required string Code { get; set; }

}