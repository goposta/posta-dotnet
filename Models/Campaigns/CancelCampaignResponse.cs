using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the CancelCampaignResponse payload.</summary>
public class CancelCampaignResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CancelCampaignResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}