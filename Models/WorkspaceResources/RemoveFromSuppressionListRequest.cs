using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the RemoveFromSuppressionListRequest payload.</summary>
public class RemoveFromSuppressionListRequest
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>Gets or sets <c>list_id</c>.</summary>
    [JsonPropertyName("list_id")]
    public int? ListId { get; set; }

}