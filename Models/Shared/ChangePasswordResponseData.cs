using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ChangePasswordResponseData payload.</summary>
public class ChangePasswordResponseData
{
    /// <summary>Gets or sets <c>message</c>.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

}