using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the CreateLocalizationResponse payload.</summary>
public class CreateLocalizationResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateLocalizationResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}