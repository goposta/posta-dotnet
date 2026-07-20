using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListSubscriberListsResponseDataItem payload.</summary>
public class ListSubscriberListsResponseDataItem
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>filter_rules</c>.</summary>
    [JsonPropertyName("filter_rules")]
    public IReadOnlyList<ListSubscriberListsResponseDataItemFilterRulesItem>? FilterRules { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>member_count</c>.</summary>
    [JsonPropertyName("member_count")]
    public long? MemberCount { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>type</c>.</summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets <c>updated_at</c>.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

}