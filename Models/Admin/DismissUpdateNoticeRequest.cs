using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Specifies the Posta version whose update notice should be dismissed.</summary>
public class DismissUpdateNoticeRequest
{
    /// <summary>Gets or sets the version to dismiss.</summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }
}
