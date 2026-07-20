using System.Text.Json.Serialization;

namespace Posta.Models.UnsubscribeLists;

/// <summary>Represents the CreateUnsubscribeListRequest payload.</summary>
public class CreateUnsubscribeListRequest
{
    /// <summary>Gets or sets <c>description</c>.</summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Gets or sets <c>public_name</c>.</summary>
    [JsonPropertyName("public_name")]
    public string? PublicName { get; set; }

}