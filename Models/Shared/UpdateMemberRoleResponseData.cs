using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the UpdateMemberRoleResponseData payload.</summary>
public class UpdateMemberRoleResponseData
{
    /// <summary>Gets or sets <c>message</c>.</summary>
    [JsonPropertyName("message")]
    public string? Message { get; set; }

}