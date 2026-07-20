using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the AssignPlanToWorkspaceRequest payload.</summary>
public class AssignPlanToWorkspaceRequest
{
    /// <summary>Gets or sets <c>plan_id</c>.</summary>
    [JsonPropertyName("plan_id")]
    public required int PlanId { get; set; }

    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}