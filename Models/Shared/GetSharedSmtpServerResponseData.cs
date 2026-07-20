using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetSharedSmtpServerResponseData payload.</summary>
public class GetSharedSmtpServerResponseData
{
    /// <summary>Gets or sets <c>AllowedDomains</c>.</summary>
    [JsonPropertyName("AllowedDomains")]
    public IReadOnlyList<string>? AllowedDomains { get; set; }

    /// <summary>Gets or sets <c>CreatedAt</c>.</summary>
    [JsonPropertyName("CreatedAt")]
    public DateTimeOffset? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>Encryption</c>.</summary>
    [JsonPropertyName("Encryption")]
    public string? Encryption { get; set; }

    /// <summary>Gets or sets <c>FailedCount</c>.</summary>
    [JsonPropertyName("FailedCount")]
    public long? FailedCount { get; set; }

    /// <summary>Gets or sets <c>Host</c>.</summary>
    [JsonPropertyName("Host")]
    public string? Host { get; set; }

    /// <summary>Gets or sets <c>Id</c>.</summary>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>MaxRetries</c>.</summary>
    [JsonPropertyName("MaxRetries")]
    public int? MaxRetries { get; set; }

    /// <summary>Gets or sets <c>Name</c>.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>Port</c>.</summary>
    [JsonPropertyName("Port")]
    public int? Port { get; set; }

    /// <summary>Gets or sets <c>SecurityMode</c>.</summary>
    [JsonPropertyName("SecurityMode")]
    public string? SecurityMode { get; set; }

    /// <summary>Gets or sets <c>SentCount</c>.</summary>
    [JsonPropertyName("SentCount")]
    public long? SentCount { get; set; }

    /// <summary>Gets or sets <c>Status</c>.</summary>
    [JsonPropertyName("Status")]
    public string? Status { get; set; }

    /// <summary>Gets or sets <c>UpdatedAt</c>.</summary>
    [JsonPropertyName("UpdatedAt")]
    public DateTimeOffset? UpdatedAt { get; set; }

    /// <summary>Gets or sets <c>Username</c>.</summary>
    [JsonPropertyName("Username")]
    public string? Username { get; set; }

    /// <summary>Gets or sets <c>ValidatedAt</c>.</summary>
    [JsonPropertyName("ValidatedAt")]
    public DateTimeOffset? ValidatedAt { get; set; }

    /// <summary>Gets or sets <c>ValidationError</c>.</summary>
    [JsonPropertyName("ValidationError")]
    public string? ValidationError { get; set; }

}