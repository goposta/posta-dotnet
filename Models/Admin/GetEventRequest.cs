using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetEventRequest payload.</summary>
public class GetEventRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}