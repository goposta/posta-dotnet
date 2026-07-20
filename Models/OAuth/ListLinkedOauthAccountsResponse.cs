using System.Text.Json.Serialization;

namespace Posta.Models.OAuth;

/// <summary>Represents the ListLinkedOauthAccountsResponse payload.</summary>
public class ListLinkedOauthAccountsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListLinkedOauthAccountsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}