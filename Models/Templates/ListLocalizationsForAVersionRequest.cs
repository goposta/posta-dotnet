using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the ListLocalizationsForAVersionRequest payload.</summary>
public class ListLocalizationsForAVersionRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

    /// <summary>Gets or sets the <c>versionId</c> path parameter.</summary>
    [JsonIgnore]
    public required int VersionId { get; set; }

}