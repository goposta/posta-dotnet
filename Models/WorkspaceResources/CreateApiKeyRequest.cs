using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the CreateApiKeyRequest payload.</summary>
public class CreateApiKeyRequest
{
    /// <summary>Gets or sets <c>allowed_ips</c>.</summary>
    [JsonPropertyName("allowed_ips")]
    public IReadOnlyList<string>? AllowedIps { get; set; }

    /// <summary>Gets or sets <c>expires_in_days</c>.</summary>
    [JsonPropertyName("expires_in_days")]
    public int? ExpiresInDays { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Gets or sets <c>scopes</c>.</summary>
    [JsonPropertyName("scopes")]
    public IReadOnlyList<string>? Scopes { get; set; }

}