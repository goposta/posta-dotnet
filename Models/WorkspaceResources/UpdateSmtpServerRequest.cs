using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the UpdateSmtpServerRequest payload.</summary>
public class UpdateSmtpServerRequest
{
    /// <summary>Gets or sets <c>allowed_emails</c>.</summary>
    [JsonPropertyName("allowed_emails")]
    public IReadOnlyList<string>? AllowedEmails { get; set; }

    /// <summary>Gets or sets <c>encryption</c>.</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Gets or sets <c>host</c>.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Gets or sets <c>max_retries</c>.</summary>
    [JsonPropertyName("max_retries")]
    public int? MaxRetries { get; set; }

    /// <summary>Gets or sets <c>password</c>.</summary>
    [JsonPropertyName("password")]
    public string? Password { get; set; }

    /// <summary>Gets or sets <c>port</c>.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

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