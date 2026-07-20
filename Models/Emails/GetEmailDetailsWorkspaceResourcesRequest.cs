using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the GetEmailDetailsWorkspaceResourcesRequest payload.</summary>
public class GetEmailDetailsWorkspaceResourcesRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required string Id { get; set; }

}