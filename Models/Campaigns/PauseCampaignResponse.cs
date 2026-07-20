using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the PauseCampaignResponse payload.</summary>
public class PauseCampaignResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.PauseCampaignResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}