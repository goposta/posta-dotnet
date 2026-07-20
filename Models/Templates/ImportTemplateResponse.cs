using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the ImportTemplateResponse payload.</summary>
public class ImportTemplateResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.ImportTemplateResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}