using System.Text.Json.Serialization;

namespace Posta.Models.Inbound;

/// <summary>Represents the DeleteAnInboundEmailRequest payload.</summary>
public class DeleteAnInboundEmailRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required string Id { get; set; }

}