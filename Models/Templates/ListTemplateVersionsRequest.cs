using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the ListTemplateVersionsRequest payload.</summary>
public class ListTemplateVersionsRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}