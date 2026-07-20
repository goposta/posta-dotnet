using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the PauseCampaignResponseDataAbTestVariantsItem payload.</summary>
public class PauseCampaignResponseDataAbTestVariantsItem
{
    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>split_percentage</c>.</summary>
    [JsonPropertyName("split_percentage")]
    public int? SplitPercentage { get; set; }

    /// <summary>Gets or sets <c>subject</c>.</summary>
    [JsonPropertyName("subject")]
    public string? Subject { get; set; }

    /// <summary>Gets or sets <c>template_id</c>.</summary>
    [JsonPropertyName("template_id")]
    public int? TemplateId { get; set; }

}