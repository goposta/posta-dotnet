using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the UpdateUserRequest payload.</summary>
public class UpdateUserRequest
{
    /// <summary>Gets or sets <c>active</c>.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>Gets or sets <c>email_verified</c>.</summary>
    [JsonPropertyName("email_verified")]
    public bool? EmailVerified { get; set; }

    /// <summary>Gets or sets <c>role</c>.</summary>
    [JsonPropertyName("role")]
    public string? Role { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}