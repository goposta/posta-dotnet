using System.Text.Json.Serialization;

namespace Posta.Models.OAuth;

/// <summary>Represents the UnlinkOauthAccountRequest payload.</summary>
public class UnlinkOauthAccountRequest
{
    /// <summary>Gets or sets the <c>provider_id</c> path parameter.</summary>
    [JsonIgnore]
    public required int ProviderId { get; set; }

}