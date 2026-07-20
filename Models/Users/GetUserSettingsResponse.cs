using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the GetUserSettingsResponse payload.</summary>
public class GetUserSettingsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetUserSettingsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}