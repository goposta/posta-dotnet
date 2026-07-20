using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the RetryFailedEmailRequest payload.</summary>
public class RetryFailedEmailRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required string Id { get; set; }

}