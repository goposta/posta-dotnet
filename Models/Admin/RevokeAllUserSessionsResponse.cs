using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the RevokeAllUserSessionsResponse payload.</summary>
public class RevokeAllUserSessionsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyDictionary<string, JsonElement>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}