using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the ResumeCampaignResponse payload.</summary>
public class ResumeCampaignResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.ResumeCampaignResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}