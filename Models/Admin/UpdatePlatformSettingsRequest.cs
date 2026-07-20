using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the UpdatePlatformSettingsRequest payload.</summary>
public class UpdatePlatformSettingsRequest
{
    /// <summary>Gets or sets <c>settings</c>.</summary>
    [JsonPropertyName("settings")]
    public required IReadOnlyList<Shared.UpdatePlatformSettingsRequestSettingsItem> Settings { get; set; }

}