using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the CancelCampaignRequest payload.</summary>
public class CancelCampaignRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}