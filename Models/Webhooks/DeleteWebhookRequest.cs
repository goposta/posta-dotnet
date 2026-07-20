using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the DeleteWebhookRequest payload.</summary>
public class DeleteWebhookRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}