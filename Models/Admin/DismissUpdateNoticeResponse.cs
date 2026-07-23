using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the response returned after dismissing an update notice.</summary>
public class DismissUpdateNoticeResponse
{
    /// <summary>Gets or sets the response data.</summary>
    [JsonPropertyName("data")]
    public Shared.MessageData? Data { get; set; }

    /// <summary>Gets or sets whether the request succeeded.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
