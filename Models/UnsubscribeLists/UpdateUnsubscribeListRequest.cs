using System.Text.Json.Serialization;

namespace Posta.Models.UnsubscribeLists;

/// <summary>Represents the UpdateUnsubscribeListRequest payload.</summary>
public class UpdateUnsubscribeListRequest
{
    /// <summary>Gets or sets <c>active</c>.</summary>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }

    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>public_name</c>.</summary>
    [JsonPropertyName("public_name")]
    public string? PublicName { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}