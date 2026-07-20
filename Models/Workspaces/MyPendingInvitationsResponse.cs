using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the MyPendingInvitationsResponse payload.</summary>
public class MyPendingInvitationsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.MyPendingInvitationsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}