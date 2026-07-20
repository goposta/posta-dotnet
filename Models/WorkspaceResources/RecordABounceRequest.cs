using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the RecordABounceRequest payload.</summary>
public class RecordABounceRequest
{
    /// <summary>Gets or sets <c>email_id</c>.</summary>
    [JsonPropertyName("email_id")]
    public required string EmailId { get; set; }

    /// <summary>Gets or sets <c>reason</c>.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

    /// <summary>Gets or sets <c>recipient</c>.</summary>
    [JsonPropertyName("recipient")]
    public required string Recipient { get; set; }

    /// <summary>Gets or sets <c>type</c>.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

}