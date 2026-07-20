using System.Text.Json.Serialization;

namespace Posta.Models.Inbound;

/// <summary>Represents the DownloadAnInboundEmailAttachmentAuthenticatedRequest payload.</summary>
public class DownloadAnInboundEmailAttachmentAuthenticatedRequest
{
    /// <summary>Gets or sets the <c>uuid</c> path parameter.</summary>
    [JsonIgnore]
    public required string Uuid { get; set; }

    /// <summary>Gets or sets the <c>idx</c> path parameter.</summary>
    [JsonIgnore]
    public required int Idx { get; set; }

}