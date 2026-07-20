using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the UpdateTemplateVersionResponse payload.</summary>
public class UpdateTemplateVersionResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdateTemplateVersionResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}