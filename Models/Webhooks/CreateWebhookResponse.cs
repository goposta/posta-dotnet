using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the CreateWebhookResponse payload.</summary>
public class CreateWebhookResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateWebhookResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}