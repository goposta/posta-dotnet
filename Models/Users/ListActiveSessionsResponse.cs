using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the ListActiveSessionsResponse payload.</summary>
public class ListActiveSessionsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListActiveSessionsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}