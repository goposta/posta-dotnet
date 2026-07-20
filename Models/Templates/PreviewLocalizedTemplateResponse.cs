using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the PreviewLocalizedTemplateResponse payload.</summary>
public class PreviewLocalizedTemplateResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.PreviewLocalizedTemplateResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}