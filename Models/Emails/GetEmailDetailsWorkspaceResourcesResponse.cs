using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the GetEmailDetailsWorkspaceResourcesResponse payload.</summary>
public class GetEmailDetailsWorkspaceResourcesResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetEmailDetailsWorkspaceResourcesResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}