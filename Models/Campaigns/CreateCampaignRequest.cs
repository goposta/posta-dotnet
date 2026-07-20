using System.Text.Json;
using System.Text.Json.Serialization;

namespace Posta.Models.Campaigns;

/// <summary>Represents the CreateCampaignRequest payload.</summary>
public class CreateCampaignRequest
{
    /// <summary>Gets or sets <c>ab_test_enabled</c>.</summary>
    [JsonPropertyName("ab_test_enabled")]
    public bool? AbTestEnabled { get; set; }

    /// <summary>Gets or sets <c>ab_test_variants</c>.</summary>
    [JsonPropertyName("ab_test_variants")]
    public IReadOnlyList<Shared.CreateCampaignRequestAbTestVariantsItem>? AbTestVariants { get; set; }

    /// <summary>Gets or sets <c>from_email</c>.</summary>
    [JsonPropertyName("from_email")]
    public required string FromEmail { get; set; }

    /// <summary>Gets or sets <c>from_name</c>.</summary>
    [JsonPropertyName("from_name")]
    public string? FromName { get; set; }

    /// <summary>Gets or sets <c>language</c>.</summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>Gets or sets <c>list_id</c>.</summary>
    [JsonPropertyName("list_id")]
    public required int ListId { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Gets or sets <c>scheduled_at</c>.</summary>
    [JsonPropertyName("scheduled_at")]
    public DateTimeOffset? ScheduledAt { get; set; }

    /// <summary>Gets or sets <c>send_at_local_time</c>.</summary>
    [JsonPropertyName("send_at_local_time")]
    public bool? SendAtLocalTime { get; set; }

    /// <summary>Gets or sets <c>send_rate</c>.</summary>
    [JsonPropertyName("send_rate")]
    public int? SendRate { get; set; }

    /// <summary>Gets or sets <c>subject</c>.</summary>
    [JsonPropertyName("subject")]
    public required string Subject { get; set; }

    /// <summary>Gets or sets <c>template_data</c>.</summary>
    [JsonPropertyName("template_data")]
    public IReadOnlyDictionary<string, JsonElement>? TemplateData { get; set; }

    /// <summary>Gets or sets <c>template_id</c>.</summary>
    [JsonPropertyName("template_id")]
    public required int TemplateId { get; set; }

    /// <summary>Gets or sets <c>template_version_id</c>.</summary>
    [JsonPropertyName("template_version_id")]
    public int? TemplateVersionId { get; set; }

}