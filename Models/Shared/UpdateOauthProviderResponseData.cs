using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the UpdateOauthProviderResponseData payload.</summary>
public class UpdateOauthProviderResponseData
{
    /// <summary>Gets or sets <c>AllowedDomains</c>.</summary>
    [JsonPropertyName("AllowedDomains")]
    public string? AllowedDomains { get; set; }

    /// <summary>Gets or sets <c>AutoRegister</c>.</summary>
    [JsonPropertyName("AutoRegister")]
    public bool? AutoRegister { get; set; }

    /// <summary>Gets or sets <c>CreatedAt</c>.</summary>
    [JsonPropertyName("CreatedAt")]
    public string? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>Enabled</c>.</summary>
    [JsonPropertyName("Enabled")]
    public bool? Enabled { get; set; }

    /// <summary>Gets or sets <c>Hidden</c>.</summary>
    [JsonPropertyName("Hidden")]
    public bool? Hidden { get; set; }

    /// <summary>Gets or sets <c>Id</c>.</summary>
    [JsonPropertyName("Id")]
    public int? Id { get; set; }

    /// <summary>Gets or sets <c>Issuer</c>.</summary>
    [JsonPropertyName("Issuer")]
    public string? Issuer { get; set; }

    /// <summary>Gets or sets <c>Name</c>.</summary>
    [JsonPropertyName("Name")]
    public string? Name { get; set; }

    /// <summary>Gets or sets <c>Scopes</c>.</summary>
    [JsonPropertyName("Scopes")]
    public string? Scopes { get; set; }

    /// <summary>Gets or sets <c>Slug</c>.</summary>
    [JsonPropertyName("Slug")]
    public string? Slug { get; set; }

    /// <summary>Gets or sets <c>Type</c>.</summary>
    [JsonPropertyName("Type")]
    public string? Type { get; set; }

}