using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetEventResponse payload.</summary>
public class GetEventResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetEventResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}