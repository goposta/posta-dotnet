using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the GetEmailDeliveryStatusWorkspaceResourcesResponseData payload.</summary>
public class GetEmailDeliveryStatusWorkspaceResourcesResponseData
{
    /// <summary>Gets or sets <c>created_at</c>.</summary>
    [JsonPropertyName("created_at")]
    public string? CreatedAt { get; set; }

    /// <summary>Gets or sets <c>error_message</c>.</summary>
    [JsonPropertyName("error_message")]
    public string? ErrorMessage { get; set; }

    /// <summary>Gets or sets <c>id</c>.</summary>
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    /// <summary>Gets or sets <c>retry_count</c>.</summary>
    [JsonPropertyName("retry_count")]
    public int? RetryCount { get; set; }

    /// <summary>Gets or sets <c>sent_at</c>.</summary>
    [JsonPropertyName("sent_at")]
    public string? SentAt { get; set; }

    /// <summary>Gets or sets <c>status</c>.</summary>
    [JsonPropertyName("status")]
    public string? Status { get; set; }

}