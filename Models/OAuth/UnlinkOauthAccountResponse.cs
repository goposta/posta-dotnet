using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.OAuth;

/// <summary>Represents the UnlinkOauthAccountResponse payload.</summary>
public class UnlinkOauthAccountResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyDictionary<string, JsonElement>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}