using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the GetUserMetricsRequest payload.</summary>
public class GetUserMetricsRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}