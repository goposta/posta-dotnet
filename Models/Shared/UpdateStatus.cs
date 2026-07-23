using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Describes the cached result of Posta's release check.</summary>
public class UpdateStatus
{
    /// <summary>Gets or sets the version currently running.</summary>
    [JsonPropertyName("current_version")]
    public string? CurrentVersion { get; set; }

    /// <summary>Gets or sets the latest available version.</summary>
    [JsonPropertyName("latest_version")]
    public string? LatestVersion { get; set; }

    /// <summary>Gets or sets the URL of the latest release.</summary>
    [JsonPropertyName("release_url")]
    public string? ReleaseUrl { get; set; }

    /// <summary>Gets or sets when the latest release was published.</summary>
    [JsonPropertyName("published_at")]
    public DateTimeOffset? PublishedAt { get; set; }

    /// <summary>Gets or sets whether an update is available and has not been dismissed.</summary>
    [JsonPropertyName("update_available")]
    public bool? UpdateAvailable { get; set; }

    /// <summary>Gets or sets whether automatic update checks are enabled.</summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Gets or sets when the latest update check completed.</summary>
    [JsonPropertyName("checked_at")]
    public DateTimeOffset? CheckedAt { get; set; }

    /// <summary>Gets or sets the error from the latest update check, if any.</summary>
    [JsonPropertyName("last_error")]
    public string? LastError { get; set; }
}
