using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the UpdateSharedSmtpServerRequest payload.</summary>
public class UpdateSharedSmtpServerRequest
{
    /// <summary>Gets or sets <c>allowed_domains</c>.</summary>
    [JsonPropertyName("allowed_domains")]
    public IReadOnlyList<string>? AllowedDomains { get; set; }

    /// <summary>Gets or sets <c>encryption</c>.</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Gets or sets <c>host</c>.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Gets or sets <c>max_retries</c>.</summary>
    [JsonPropertyName("max_retries")]
    public int? MaxRetries { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>password</c>.</summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>Gets or sets <c>port</c>.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Gets or sets <c>security_mode</c>.</summary>
    [JsonPropertyName("security_mode")]
    public string? SecurityMode { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>username</c>.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}