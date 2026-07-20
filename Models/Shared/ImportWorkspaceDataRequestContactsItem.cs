using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ImportWorkspaceDataRequestContactsItem payload.</summary>
public class ImportWorkspaceDataRequestContactsItem
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>fail_count</c>.</summary>
    [JsonPropertyName("fail_count")]
    public long? FailCount { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>sent_count</c>.</summary>
    [JsonPropertyName("sent_count")]
    public long? SentCount { get; set; }

}