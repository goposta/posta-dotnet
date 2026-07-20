using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the DeleteOauthProviderRequest payload.</summary>
public class DeleteOauthProviderRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}