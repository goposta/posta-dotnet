using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the Disable2faForUserRequest payload.</summary>
public class Disable2faForUserRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}