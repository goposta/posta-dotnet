using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetCampaignResponseDataStats payload.</summary>
public class GetCampaignResponseDataStats
{
    /// <summary>Gets or sets <c>failed</c>.</summary>
    [JsonPropertyName("failed")]
    public long? Failed { get; set; }

    /// <summary>Gets or sets <c>pending</c>.</summary>
    [JsonPropertyName("pending")]
    public long? Pending { get; set; }

    /// <summary>Gets or sets <c>queued</c>.</summary>
    [JsonPropertyName("queued")]
    public long? Queued { get; set; }

    /// <summary>Gets or sets <c>sent</c>.</summary>
    [JsonPropertyName("sent")]
    public long? Sent { get; set; }

    /// <summary>Gets or sets <c>skipped</c>.</summary>
    [JsonPropertyName("skipped")]
    public long? Skipped { get; set; }

    /// <summary>Gets or sets <c>total</c>.</summary>
    [JsonPropertyName("total")]
    public long? Total { get; set; }

}