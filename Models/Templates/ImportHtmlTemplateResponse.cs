using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the ImportHtmlTemplateResponse payload.</summary>
public class ImportHtmlTemplateResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.ImportHtmlTemplateResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}