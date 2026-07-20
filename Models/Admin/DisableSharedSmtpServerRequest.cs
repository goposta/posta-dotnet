using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the DisableSharedSmtpServerRequest payload.</summary>
public class DisableSharedSmtpServerRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}