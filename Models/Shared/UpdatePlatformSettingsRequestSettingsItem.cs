using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the UpdatePlatformSettingsRequestSettingsItem payload.</summary>
public class UpdatePlatformSettingsRequestSettingsItem
{
    /// <summary>Gets or sets <c>Key</c>.</summary>
    [JsonPropertyName("Key")]
    public string? Key { get; set; }

    /// <summary>Gets or sets <c>Type</c>.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets <c>Value</c>.</summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

}