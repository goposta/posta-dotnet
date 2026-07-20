using System.Text.Json.Serialization;

namespace Posta.Models.OAuth;

/// <summary>Represents the InitiateOauthFlowRequest payload.</summary>
public class InitiateOauthFlowRequest
{
    /// <summary>Gets or sets the <c>provider</c> path parameter.</summary>
    [JsonIgnore]
    public required string Provider { get; set; }

}