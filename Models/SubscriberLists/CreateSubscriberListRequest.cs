using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the CreateSubscriberListRequest payload.</summary>
public class CreateSubscriberListRequest
{
    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>filter_rules</c>.</summary>
    [JsonPropertyName("filter_rules")]
    public IReadOnlyList<Shared.CreateSubscriberListRequestFilterRulesItem>? FilterRules { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Gets or sets <c>type</c>.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

}