using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListCampaignsResponseDataItem payload.</summary>
public class ListCampaignsResponseDataItem
{
    /// <summary>Gets or sets <c>ab_test_enabled</c>.</summary>
    [JsonPropertyName("ab_test_enabled")]
    public bool? AbTestEnabled { get; set; }

    /// <summary>Gets or sets <c>ab_test_variants</c>.</summary>
    [JsonPropertyName("ab_test_variants")]
    public IReadOnlyList<ListCampaignsResponseDataItemAbTestVariantsItem>? AbTestVariants { get; set; }

    /// <summary>Gets or sets <c>ab_test_winner</c>.</summary>
    [JsonPropertyName("ab_test_winner")]
    public string? AbTestWinner { get; set; }

    /// <summary>Gets or sets <c>completed_at</c>.</summary>
    [JsonPropertyName("completed_at")]
    public DateTimeOffset? CompletedAt { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>from_email</c>.</summary>
    [JsonPropertyName("from_email")]
    public string? FromEmail { get; set; }

    /// <summary>Gets or sets <c>from_name</c>.</summary>
    [JsonPropertyName("from_name")]
    public string? FromName { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>Gets or sets <c>list_id</c>.</summary>
    [JsonPropertyName("list_id")]
    public int? ListId { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>scheduled_at</c>.</summary>
    [JsonPropertyName("scheduled_at")]
    public DateTimeOffset? ScheduledAt { get; set; }

    /// <summary>Gets or sets <c>send_at_local_time</c>.</summary>
    [JsonPropertyName("send_at_local_time")]
    public bool? SendAtLocalTime { get; set; }

    /// <summary>Gets or sets <c>send_rate</c>.</summary>
    [JsonPropertyName("send_rate")]
    public int? SendRate { get; set; }

    /// <summary>Gets or sets <c>snapshot</c>.</summary>
    [JsonPropertyName("snapshot")]
    public IReadOnlyDictionary<string, JsonElement>? Snapshot { get; set; }

    /// <summary>Gets or sets <c>started_at</c>.</summary>
    [JsonPropertyName("started_at")]
    public DateTimeOffset? StartedAt { get; set; }

    /// <summary>Gets or sets <c>stats</c>.</summary>
    [JsonPropertyName("stats")]
    public ListCampaignsResponseDataItemStats? Stats { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>subject</c>.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Gets or sets <c>template_data</c>.</summary>
    [JsonPropertyName("template_data")]
    public IReadOnlyDictionary<string, JsonElement>? TemplateData { get; set; }

    /// <summary>Gets or sets <c>template_id</c>.</summary>
    [JsonPropertyName("template_id")]
    public int? TemplateId { get; set; }

    /// <summary>Gets or sets <c>template_version_id</c>.</summary>
    [JsonPropertyName("template_version_id")]
    public int? TemplateVersionId { get; set; }

    /// <summary>Gets or sets <c>updated_at</c>.</summary>
    [JsonPropertyName("updated_at")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}