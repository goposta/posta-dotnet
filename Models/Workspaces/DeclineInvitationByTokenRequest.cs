using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the DeclineInvitationByTokenRequest payload.</summary>
public class DeclineInvitationByTokenRequest
{
    /// <summary>Gets or sets <c>token</c>.</summary>
    [JsonPropertyName("token")]
    public required string Token { get; set; }

}