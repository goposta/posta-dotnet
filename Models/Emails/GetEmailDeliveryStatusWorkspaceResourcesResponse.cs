using System.Text.Json.Serialization;

namespace Posta.Models.Emails;

/// <summary>Represents the GetEmailDeliveryStatusWorkspaceResourcesResponse payload.</summary>
public class GetEmailDeliveryStatusWorkspaceResourcesResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetEmailDeliveryStatusWorkspaceResourcesResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}