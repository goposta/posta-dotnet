using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetWorkspacePlanRequest payload.</summary>
public class GetWorkspacePlanRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}