using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the ResumeCampaignRequest payload.</summary>
public class ResumeCampaignRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}