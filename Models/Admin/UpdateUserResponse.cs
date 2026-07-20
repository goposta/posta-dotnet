using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the UpdateUserResponse payload.</summary>
public class UpdateUserResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.UpdateUserResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}