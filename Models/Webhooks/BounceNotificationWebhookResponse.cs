using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the BounceNotificationWebhookResponse payload.</summary>
public class BounceNotificationWebhookResponse
{
    /// <summary>Gets or sets <c>action</c>.</summary>
    [JsonPropertyName("action")]
    public string? Action { get; set; }

    /// <summary>Gets or sets <c>processed</c>.</summary>
    [JsonPropertyName("processed")]
    public bool? Processed { get; set; }

}