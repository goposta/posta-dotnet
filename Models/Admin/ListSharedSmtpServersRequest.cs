using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the ListSharedSmtpServersRequest payload.</summary>
public class ListSharedSmtpServersRequest
{
    /// <summary>Gets or sets the <c>page</c> query parameter.</summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>Gets or sets the <c>size</c> query parameter.</summary>
    [JsonIgnore]
    public int? Size { get; set; }

    /// <summary>Gets or sets the <c>search</c> query parameter.</summary>
    [JsonIgnore]
    public string? Search { get; set; }

}