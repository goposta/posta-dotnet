using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the DisableSharedSmtpServerResponse payload.</summary>
public class DisableSharedSmtpServerResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.DisableSharedSmtpServerResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}