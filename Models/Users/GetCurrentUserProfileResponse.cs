using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the GetCurrentUserProfileResponse payload.</summary>
public class GetCurrentUserProfileResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.GetCurrentUserProfileResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}