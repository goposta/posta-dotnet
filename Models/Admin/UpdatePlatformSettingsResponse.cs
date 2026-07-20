using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the UpdatePlatformSettingsResponse payload.</summary>
public class UpdatePlatformSettingsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.UpdatePlatformSettingsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}