using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the AssignPlanToUserResponse payload.</summary>
public class AssignPlanToUserResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.AssignPlanToUserResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}