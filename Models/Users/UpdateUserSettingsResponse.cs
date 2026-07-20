using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the UpdateUserSettingsResponse payload.</summary>
public class UpdateUserSettingsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdateUserSettingsResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}