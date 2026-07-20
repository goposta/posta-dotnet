using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the RevokeSessionRequest payload.</summary>
public class RevokeSessionRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}