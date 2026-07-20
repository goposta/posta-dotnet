using System.Text.Json.Serialization;

namespace Posta.Models.Inbound;

/// <summary>Represents the RetryWebhookDispatchForAFailedInboundEmailRequest payload.</summary>
public class RetryWebhookDispatchForAFailedInboundEmailRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required string Id { get; set; }

}