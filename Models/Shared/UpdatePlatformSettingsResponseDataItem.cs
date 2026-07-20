using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the UpdatePlatformSettingsResponseDataItem payload.</summary>
public class UpdatePlatformSettingsResponseDataItem
{
    /// <summary>Gets or sets <c>CreatedAt</c>.</summary>
    [JsonPropertyName("CreatedAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>Id</c>.</summary>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>Key</c>.</summary>
    [JsonPropertyName("Key")]
    public string? Key { get; set; }

    /// <summary>Gets or sets <c>Type</c>.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets <c>UpdatedAt</c>.</summary>
    [JsonPropertyName("UpdatedAt")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>Gets or sets <c>Value</c>.</summary>
    [JsonPropertyName("Value")]
    public string? Value { get; set; }

}