using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the UpdateSubscriberListRequestFilterRulesItem payload.</summary>
public class UpdateSubscriberListRequestFilterRulesItem
{
    /// <summary>Gets or sets <c>field</c>.</summary>
    [JsonPropertyName("field")]
    public string? Field { get; set; }

    /// <summary>Gets or sets <c>operator</c>.</summary>
    [JsonPropertyName("operator")]
    public string? Operator { get; set; }

    /// <summary>Gets or sets <c>value</c>.</summary>
    [JsonPropertyName("value")]
    public JsonElement? Value { get; set; }

}