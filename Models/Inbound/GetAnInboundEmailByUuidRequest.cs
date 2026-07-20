using System.Text.Json.Serialization;

namespace Posta.Models.Inbound;

/// <summary>Represents the GetAnInboundEmailByUuidRequest payload.</summary>
public class GetAnInboundEmailByUuidRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required string Id { get; set; }

}