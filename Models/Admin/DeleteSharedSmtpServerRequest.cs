using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the DeleteSharedSmtpServerRequest payload.</summary>
public class DeleteSharedSmtpServerRequest
{
    /// <summary>Gets or sets the <c>id</c> path parameter.</summary>
    [JsonIgnore]
    public required int Id { get; set; }

}