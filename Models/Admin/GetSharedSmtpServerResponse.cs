using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetSharedSmtpServerResponse payload.</summary>
public class GetSharedSmtpServerResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetSharedSmtpServerResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}