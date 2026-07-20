using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the CreateOauthProviderRequest payload.</summary>
public class CreateOauthProviderRequest
{
    /// <summary>Gets or sets <c>allowed_domains</c>.</summary>
    [JsonPropertyName("allowed_domains")]
    public string? AllowedDomains { get; set; }

    /// <summary>Gets or sets <c>auth_url</c>.</summary>
    [JsonPropertyName("auth_url")]
    public string? AuthUrl { get; set; }

    /// <summary>Gets or sets <c>auto_register</c>.</summary>
    [JsonPropertyName("auto_register")]
    public bool? AutoRegister { get; set; }

    /// <summary>Gets or sets <c>client_id</c>.</summary>
    [JsonPropertyName("client_id")]
    public required string ClientId { get; set; }

    /// <summary>Gets or sets <c>client_secret</c>.</summary>
    [JsonPropertyName("client_secret")]
    public required string ClientSecret { get; set; }

    /// <summary>Gets or sets <c>hidden</c>.</summary>
    [JsonPropertyName("hidden")]
    public bool? Hidden { get; set; }

    /// <summary>Gets or sets <c>issuer</c>.</summary>
    [JsonPropertyName("issuer")]
    public string? Issuer { get; set; }

    /// <summary>Gets or sets <c>name</c>.</summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>Gets or sets <c>scopes</c>.</summary>
    [JsonPropertyName("scopes")]
    public string? Scopes { get; set; }

    /// <summary>Gets or sets <c>slug</c>.</summary>
    [JsonPropertyName("slug")]
    public required string Slug { get; set; }

    /// <summary>Gets or sets <c>token_url</c>.</summary>
    [JsonPropertyName("token_url")]
    public string? TokenUrl { get; set; }

    /// <summary>Gets or sets <c>type</c>.</summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>Gets or sets <c>userinfo_url</c>.</summary>
    [JsonPropertyName("userinfo_url")]
    public string? UserinfoUrl { get; set; }

}