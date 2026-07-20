using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the UpdateProfileResponse payload.</summary>
public class UpdateProfileResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdateProfileResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}