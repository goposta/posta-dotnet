using System.Text.Json.Serialization;

namespace Posta.Models.Inbound;

/// <summary>Represents the ListInboundEmailsRequest payload.</summary>
public class ListInboundEmailsRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

    /// <summary>Gets or sets the <c>status</c> query parameter.</summary>
    [JsonIgnore]
    public string? Status { get; set; }

    /// <summary>Gets or sets the <c>source</c> query parameter.</summary>
    [JsonIgnore]
    public string? Source { get; set; }

    /// <summary>Gets or sets the <c>sender</c> query parameter.</summary>
    [JsonIgnore]
    public string? Sender { get; set; }

    /// <summary>Gets or sets the <c>q</c> query parameter.</summary>
    [JsonIgnore]
    public string? Q { get; set; }

}