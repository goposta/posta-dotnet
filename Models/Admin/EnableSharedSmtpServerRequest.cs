using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the EnableSharedSmtpServerRequest payload.</summary>
public class EnableSharedSmtpServerRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}