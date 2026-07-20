using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the CreateSharedSmtpServerResponse payload.</summary>
public class CreateSharedSmtpServerResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateSharedSmtpServerResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}