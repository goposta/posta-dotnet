using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the ExportTemplateResponse payload.</summary>
public class ExportTemplateResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.ExportTemplateResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}