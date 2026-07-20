using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the RetryFailedEmailWorkspaceResourcesResponse payload.</summary>
public class RetryFailedEmailWorkspaceResourcesResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.RetryFailedEmailWorkspaceResourcesResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}