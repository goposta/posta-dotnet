using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DiscoverSsoProviderByEmailResponseData payload.</summary>
public class DiscoverSsoProviderByEmailResponseData
{
    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>slug</c>.</summary>
    [JsonPropertyName("slug")]
    public string? Slug { get; set; }

    /// <summary>Gets or sets <c>type</c>.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

}