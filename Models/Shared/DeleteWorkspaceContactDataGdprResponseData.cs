using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the DeleteWorkspaceContactDataGdprResponseData payload.</summary>
public class DeleteWorkspaceContactDataGdprResponseData
{
    /// <summary>Gets or sets <c>deleted</c>.</summary>
    [JsonPropertyName("deleted")]
    public long? Deleted { get; set; }

    /// <summary>Gets or sets <c>message</c>.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

}