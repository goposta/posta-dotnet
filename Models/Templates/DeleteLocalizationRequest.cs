using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Represents the DeleteLocalizationRequest payload.</summary>
public class DeleteLocalizationRequest
{
    /// <summary>Gets or sets the <c>localizationId</c> path parameter.</summary>
    [JsonIgnore]
    public required int LocalizationId { get; set; }

}