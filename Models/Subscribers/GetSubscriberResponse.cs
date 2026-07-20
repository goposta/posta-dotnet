using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the GetSubscriberResponse payload.</summary>
public class GetSubscriberResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetSubscriberResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}