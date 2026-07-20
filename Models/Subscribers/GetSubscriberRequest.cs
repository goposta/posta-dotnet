using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the GetSubscriberRequest payload.</summary>
public class GetSubscriberRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}