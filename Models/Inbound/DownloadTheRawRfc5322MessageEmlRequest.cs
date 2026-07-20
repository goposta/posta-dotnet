using System.Text.Json.Serialization;

namespace Posta.Models.Inbound;

/// <summary>Represents the DownloadTheRawRfc5322MessageEmlRequest payload.</summary>
public class DownloadTheRawRfc5322MessageEmlRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required string Id { get; set; }

}