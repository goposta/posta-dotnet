using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the Disable2faForUserResponse payload.</summary>
public class Disable2faForUserResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyDictionary<string, JsonElement>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}