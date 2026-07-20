using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the BounceNotificationWebhookRequest payload.</summary>
public class BounceNotificationWebhookRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Gets or sets <c>email_id</c>.</summary>
    [JsonPropertyName("email_id")]
    public string? EmailId { get; set; }

    /// <summary>Gets or sets <c>reason</c>.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Gets or sets <c>type</c>.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

}