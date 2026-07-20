using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the CreateANewUserResponse payload.</summary>
public class CreateANewUserResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.CreateANewUserResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}