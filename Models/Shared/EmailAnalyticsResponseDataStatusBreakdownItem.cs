using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the EmailAnalyticsResponseDataStatusBreakdownItem payload.</summary>
public class EmailAnalyticsResponseDataStatusBreakdownItem
{
    /// <summary>Gets or sets <c>count</c>.</summary>
    [JsonPropertyName("count")]
    public long? Count { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

}