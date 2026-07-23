using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the response returned by the Posta update-status endpoint.</summary>
public class GetUpdateStatusResponse
{
    /// <summary>Gets or sets the update status.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdateStatus? Data { get; set; }

    /// <summary>Gets or sets whether the request succeeded.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
