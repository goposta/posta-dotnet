using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetWorkspacePlanResponse payload.</summary>
public class GetWorkspacePlanResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetWorkspacePlanResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}