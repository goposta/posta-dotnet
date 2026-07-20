using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the DeleteCampaignRequest payload.</summary>
public class DeleteCampaignRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}