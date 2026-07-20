using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ListEventsResponseDataItem payload.</summary>
public class ListEventsResponseDataItem
{
    /// <summary>Gets or sets <c>ActorId</c>.</summary>
    [JsonPropertyName("ActorId")]
    public int? ActorId { get; set; }

    /// <summary>Gets or sets <c>ActorName</c>.</summary>
    [JsonPropertyName("ActorName")]
    public string? ActorName { get; set; }

    /// <summary>Gets or sets <c>Category</c>.</summary>
    [JsonPropertyName("Category")]
    public string? Category { get; set; }

    /// <summary>Gets or sets <c>ClientIp</c>.</summary>
    [JsonPropertyName("ClientIp")]
    public string? ClientIp { get; set; }

    /// <summary>Gets or sets <c>CreatedAt</c>.</summary>
    [JsonPropertyName("CreatedAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>Id</c>.</summary>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>Message</c>.</summary>
    [JsonPropertyName("Message")]
    public string? Message { get; set; }

    /// <summary>Gets or sets <c>Metadata</c>.</summary>
    [JsonPropertyName("Metadata")]
    public string? Metadata { get; set; }

    /// <summary>Gets or sets <c>Type</c>.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

    /// <summary>Gets or sets <c>WorkspaceId</c>.</summary>
    [JsonPropertyName("WorkspaceId")]
    public int? WorkspaceId { get; set; }

}