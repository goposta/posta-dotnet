using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the CreateCampaignResponse payload.</summary>
public class CreateCampaignResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateCampaignResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}