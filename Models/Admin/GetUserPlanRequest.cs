using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetUserPlanRequest payload.</summary>
public class GetUserPlanRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}