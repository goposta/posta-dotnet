using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListActiveSessionsResponseDataItem payload.</summary>
public class ListActiveSessionsResponseDataItem
{
    /// <summary>Gets or sets <c>browser</c>.</summary>
    [JsonPropertyName("browser")]
    public string? Browser { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>current</c>.</summary>
    [JsonPropertyName("current")]
    public bool? Current { get; set; }

    /// <summary>Gets or sets <c>device</c>.</summary>
    [JsonPropertyName("device")]
    public string? Device { get; set; }

    /// <summary>Gets or sets <c>expires_at</c>.</summary>
    [JsonPropertyName("expires_at")]
    public string? ExpiresAt { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>ip_address</c>.</summary>
    [JsonPropertyName("ip_address")]
    public string? IpAddress { get; set; }

    /// <summary>Gets or sets <c>label</c>.</summary>
    [JsonPropertyName("label")]
    public string? Label { get; set; }

    /// <summary>Gets or sets <c>os</c>.</summary>
    [JsonPropertyName("os")]
    public string? Os { get; set; }

    /// <summary>Gets or sets <c>user_agent</c>.</summary>
    [JsonPropertyName("user_agent")]
    public string? UserAgent { get; set; }

}