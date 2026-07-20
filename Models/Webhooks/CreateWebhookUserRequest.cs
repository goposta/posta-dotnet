using System.Text.Json.Serialization;

namespace Posta.Models.Webhooks;

/// <summary>Represents the CreateWebhookUserRequest payload.</summary>
public class CreateWebhookUserRequest
{
    /// <summary>Gets or sets <c>events</c>.</summary>
    [JsonPropertyName("events")]
    public required IReadOnlyList<string> Events { get; set; }

    /// <summary>Gets or sets <c>filters</c>.</summary>
    [JsonPropertyName("filters")]
    public IReadOnlyList<string>? Filters { get; set; }

    /// <summary>Gets or sets <c>url</c>.</summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

}