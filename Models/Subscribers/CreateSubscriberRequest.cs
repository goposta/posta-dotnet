using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Represents the CreateSubscriberRequest payload.</summary>
public class CreateSubscriberRequest
{
    /// <summary>Gets or sets <c>custom_fields</c>.</summary>
    [JsonPropertyName("custom_fields")]
    public IReadOnlyDictionary<string, JsonElement>? CustomFields { get; set; }

    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>timezone</c>.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

}