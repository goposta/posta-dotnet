using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the DeclineInvitationByIdRequest payload.</summary>
public class DeclineInvitationByIdRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}