using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the SetWorkspaceSsoConfigRequest payload.</summary>
public class SetWorkspaceSsoConfigRequest
{
    /// <summary>Gets or sets <c>allowed_domains</c>.</summary>
    [JsonPropertyName("allowed_domains")]
    public string? AllowedDomains { get; set; }

    /// <summary>Gets or sets <c>auto_provision</c>.</summary>
    [JsonPropertyName("auto_provision")]
    public bool? AutoProvision { get; set; }

    /// <summary>Gets or sets <c>enforce_sso</c>.</summary>
    [JsonPropertyName("enforce_sso")]
    public bool? EnforceSso { get; set; }

    /// <summary>Gets or sets <c>provider_id</c>.</summary>
    [JsonPropertyName("provider_id")]
    public required int ProviderId { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}