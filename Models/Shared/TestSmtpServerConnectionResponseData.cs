using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the TestSmtpServerConnectionResponseData payload.</summary>
public class TestSmtpServerConnectionResponseData
{
    /// <summary>Gets or sets <c>message</c>.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

}