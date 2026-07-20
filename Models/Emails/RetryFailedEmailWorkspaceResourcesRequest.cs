using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the RetryFailedEmailWorkspaceResourcesRequest payload.</summary>
public class RetryFailedEmailWorkspaceResourcesRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required string Id { get; set; }

}