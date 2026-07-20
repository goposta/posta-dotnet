using System.Text.Json.Serialization;

namespace Posta.Models.Admin;

/// <summary>Represents the ListSharedSmtpServersResponse payload.</summary>
public class ListSharedSmtpServersResponse
{
    /// <summary>Gets or sets <c>data</c>.</summary>
    [JsonPropertyName("data")]
    public IReadOnlyList<Shared.ListSharedSmtpServersResponseDataItem>? Data { get; set; }

    /// <summary>Gets or sets <c>pageable</c>.</summary>
    [JsonPropertyName("pageable")]
    public Shared.ListSharedSmtpServersResponsePageable? Pageable { get; set; }

    /// <summary>Gets or sets <c>success</c>.</summary>
    [JsonPropertyName("success")]
    public bool? Success { get; set; }

}