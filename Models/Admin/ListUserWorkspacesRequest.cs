using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the ListUserWorkspacesRequest payload.</summary>
public class ListUserWorkspacesRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}