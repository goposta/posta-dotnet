using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetUserPlanResponse payload.</summary>
public class GetUserPlanResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetUserPlanResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}