using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the AcceptInvitationRequest payload.</summary>
public class AcceptInvitationRequest
{
    /// <summary>Gets or sets <c>token</c>.</summary>
    [JsonPropertyName("token")]
    public required string Token { get; set; }

}