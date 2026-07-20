using System.Text.Json.Serialization;

namespace Posta.Models.UnsubscribeLists;

/// <summary>Represents the DeleteUnsubscribeListRequest payload.</summary>
public class DeleteUnsubscribeListRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}