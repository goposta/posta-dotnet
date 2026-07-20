using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the Setup2faResponseData payload.</summary>
public class Setup2faResponseData
{
    /// <summary>Gets or sets <c>secret</c>.</summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>Gets or sets <c>url</c>.</summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

}