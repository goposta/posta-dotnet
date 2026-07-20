using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the CreateTemplateVersionResponse payload.</summary>
public class CreateTemplateVersionResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateTemplateVersionResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}