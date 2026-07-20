using System.Text.Json.Serialization;

namespace Posta.Models.WorkspaceResources;

/// <summary>Represents the DeliverabilityByProviderRequest payload.</summary>
public class DeliverabilityByProviderRequest
{
    /// <summary>Gets or sets the <c>from</c> query parameter.</summary>
    [JsonIgnore]
    public string? From { get; set; }

    /// <summary>Gets or sets the <c>to</c> query parameter.</summary>
    [JsonIgnore]
    public string? To { get; set; }

}