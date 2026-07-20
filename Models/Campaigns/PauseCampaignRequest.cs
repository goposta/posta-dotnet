using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the PauseCampaignRequest payload.</summary>
public class PauseCampaignRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}