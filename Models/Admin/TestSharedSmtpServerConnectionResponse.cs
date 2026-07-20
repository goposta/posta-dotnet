using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the TestSharedSmtpServerConnectionResponse payload.</summary>
public class TestSharedSmtpServerConnectionResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.TestSharedSmtpServerConnectionResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}