using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the UpdatePlanResponse payload.</summary>
public class UpdatePlanResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdatePlanResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}