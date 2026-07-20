using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the EnableSharedSmtpServerResponse payload.</summary>
public class EnableSharedSmtpServerResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.EnableSharedSmtpServerResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}