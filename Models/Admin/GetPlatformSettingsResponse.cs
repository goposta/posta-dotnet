using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetPlatformSettingsResponse payload.</summary>
public class GetPlatformSettingsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.GetPlatformSettingsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}