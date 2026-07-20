using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the AcceptInvitationByIdRequest payload.</summary>
public class AcceptInvitationByIdRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}