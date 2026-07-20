using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the AssignPlanToUserResponseData payload.</summary>
public class AssignPlanToUserResponseData
{
    /// <summary>Gets or sets <c>Message</c>.</summary>
    [JsonPropertyName("Message")]
    public string? Message { get; set; }

}