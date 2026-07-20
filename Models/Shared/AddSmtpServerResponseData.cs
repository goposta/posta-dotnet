using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the AddSmtpServerResponseData payload.</summary>
public class AddSmtpServerResponseData
{
    /// <summary>Gets or sets <c>allowed_emails</c>.</summary>
    [JsonPropertyName("allowed_emails")]
    public IReadOnlyList<string>? AllowedEmails { get; set; }

    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>encryption</c>.</summary>
    [JsonPropertyName("encryption")]
    public string? Encryption { get; set; }

    /// <summary>Gets or sets <c>host</c>.</summary>
    [JsonPropertyName("host")]
    public string? Host { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>max_retries</c>.</summary>
    [JsonPropertyName("max_retries")]
    public int? MaxRetries { get; set; }

    /// <summary>Gets or sets <c>port</c>.</summary>
    [JsonPropertyName("port")]
    public int? Port { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>user_id</c>.</summary>
    [JsonPropertyName("user_id")]
    public int? UserId { get; set; }

    /// <summary>Gets or sets <c>username</c>.</summary>
    [JsonPropertyName("username")]
    public string? Username { get; set; }

    /// <summary>Gets or sets <c>validated_at</c>.</summary>
    [JsonPropertyName("validated_at")]
    public DateTimeOffset? ValidatedAt { get; set; }

    /// <summary>Gets or sets <c>validation_error</c>.</summary>
    [JsonPropertyName("validation_error")]
    public string? ValidationError { get; set; }

    /// <summary>Gets or sets <c>workspace_id</c>.</summary>
    [JsonPropertyName("workspace_id")]
    public int? WorkspaceId { get; set; }

}