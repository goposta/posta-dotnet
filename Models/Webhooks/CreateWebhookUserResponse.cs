using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the CreateWebhookUserResponse payload.</summary>
public class CreateWebhookUserResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateWebhookUserResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}