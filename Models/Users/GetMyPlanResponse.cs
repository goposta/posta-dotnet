using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the GetMyPlanResponse payload.</summary>
public class GetMyPlanResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetMyPlanResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}