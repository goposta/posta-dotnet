using System.Text.Json.Serialization;

namespace Posta.Models.UnsubscribeLists;

/// <summary>Represents the GetUnsubscribeListResponse payload.</summary>
public class GetUnsubscribeListResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetUnsubscribeListResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}