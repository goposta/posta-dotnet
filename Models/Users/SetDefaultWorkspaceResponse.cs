using System.Text.Json.Serialization;

namespace Posta.Models.Users;

/// <summary>Represents the response from setting the default workspace.</summary>
public sealed class SetDefaultWorkspaceResponse
{
    [JsonPropertyName("success")]
    public bool? Success { get; set; }
}
