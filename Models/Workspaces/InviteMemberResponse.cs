using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the InviteMemberResponse payload.</summary>
public class InviteMemberResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public Shared.InviteMemberResponseData? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}