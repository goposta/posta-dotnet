using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the AssignPlanToWorkspaceResponseData payload.</summary>
public class AssignPlanToWorkspaceResponseData
{
    /// <summary>Gets or sets <c>Message</c>.</summary>
    [JsonPropertyName("Message")]
    public string? Message { get; set; }

}