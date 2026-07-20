using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the UpdateLocalizationResponse payload.</summary>
public class UpdateLocalizationResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdateLocalizationResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}