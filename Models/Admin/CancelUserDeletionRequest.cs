using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the CancelUserDeletionRequest payload.</summary>
public class CancelUserDeletionRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}