using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the DeleteWebhookUserRequest payload.</summary>
public class DeleteWebhookUserRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}