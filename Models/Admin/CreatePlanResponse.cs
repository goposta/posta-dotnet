using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the CreatePlanResponse payload.</summary>
public class CreatePlanResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreatePlanResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}