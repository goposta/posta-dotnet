using System.Text.Json.Serialization;

namespace Posta.Models.Subscribers;

/// <summary>Arguments for importing subscribers from a CSV file.</summary>
public sealed class BulkImportSubscribersCsvRequest
{
    /// <summary>Gets or sets the CSV file contents.</summary>
    [JsonIgnore]
    public required byte[] File { get; set; }

    /// <summary>Gets or sets the uploaded file name.</summary>
    [JsonIgnore]
    public string FileName { get; set; } = "subscribers.csv";

    /// <summary>Gets or sets an optional mapping from zero-based column indexes to subscriber fields.</summary>
    [JsonIgnore]
    public IReadOnlyDictionary<int, string>? ColumnMapping { get; set; }
}
