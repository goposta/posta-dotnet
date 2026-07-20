using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the UpdateSharedSmtpServerResponse payload.</summary>
public class UpdateSharedSmtpServerResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdateSharedSmtpServerResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}