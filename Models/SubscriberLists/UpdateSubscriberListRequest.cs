using System.Text.Json.Serialization;

namespace Posta.Models.SubscriberLists;

/// <summary>Represents the UpdateSubscriberListRequest payload.</summary>
public class UpdateSubscriberListRequest
{
    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>filter_rules</c>.</summary>
    [JsonPropertyName("filter_rules")]
    public IReadOnlyList<Shared.UpdateSubscriberListRequestFilterRulesItem>? FilterRules { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}