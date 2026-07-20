using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the ListTemplateVersionsResponse payload.</summary>
public class ListTemplateVersionsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListTemplateVersionsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}