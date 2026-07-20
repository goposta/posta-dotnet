using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the CreateSubscriberResponse payload.</summary>
public class CreateSubscriberResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateSubscriberResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}