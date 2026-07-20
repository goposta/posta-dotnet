using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the ListPendingInvitationsResponse payload.</summary>
public class ListPendingInvitationsResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListPendingInvitationsResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}