using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the DuplicateCampaignResponse payload.</summary>
public class DuplicateCampaignResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.DuplicateCampaignResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}