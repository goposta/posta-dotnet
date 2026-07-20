using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the TestSharedSmtpServerConnectionResponseData payload.</summary>
public class TestSharedSmtpServerConnectionResponseData
{
    /// <summary>Gets or sets <c>Message</c>.</summary>
    [JsonPropertyName("Message")]
    public string? Message { get; set; }

}