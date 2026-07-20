using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the GetCampaignResponse payload.</summary>
public class GetCampaignResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetCampaignResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}