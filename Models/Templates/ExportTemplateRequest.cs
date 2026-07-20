using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the ExportTemplateRequest payload.</summary>
public class ExportTemplateRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}