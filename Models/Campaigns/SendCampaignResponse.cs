using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the SendCampaignResponse payload.</summary>
public class SendCampaignResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.SendCampaignResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}