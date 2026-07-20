using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the Setup2faResponse payload.</summary>
public class Setup2faResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.Setup2faResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}