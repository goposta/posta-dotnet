using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the DeleteSubscriberRequest payload.</summary>
public class DeleteSubscriberRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}