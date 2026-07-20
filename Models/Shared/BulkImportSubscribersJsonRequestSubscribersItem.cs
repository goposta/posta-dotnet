using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the BulkImportSubscribersJsonRequestSubscribersItem payload.</summary>
public class BulkImportSubscribersJsonRequestSubscribersItem
{
    /// <summary>Gets or sets <c>custom_fields</c>.</summary>
    [JsonPropertyName("custom_fields")]
    public IReadOnlyDictionary<string, JsonElement>? CustomFields { get; set; }

    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>timezone</c>.</summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

}