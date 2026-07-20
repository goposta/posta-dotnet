using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseDataSuppressionsItem payload.</summary>
public class ExportWorkspaceDataResponseDataSuppressionsItem
{
    /// <summary>Gets or sets <c>email</c>.</summary>
    [JsonPropertyName("email")]
    public string? Email { get; set; }

    /// <summary>Gets or sets <c>reason</c>.</summary>
    [JsonPropertyName("reason")]
    public string? Reason { get; set; }

}