using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the DeletePlanRequest payload.</summary>
public class DeletePlanRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

    /// <summary>Gets or sets the <c>force</c> query parameter.</summary>
    [JsonIgnore]
    public bool? Force { get; set; }

}