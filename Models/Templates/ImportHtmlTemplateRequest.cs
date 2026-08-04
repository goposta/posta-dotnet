using System.Text.Json.Serialization;

namespace Posta.Models.Templates;

/// <summary>Arguments for creating a template from an HTML file.</summary>
public sealed class ImportHtmlTemplateRequest
{
    /// <summary>Gets or sets the HTML file contents. Posta accepts files up to 2 MiB.</summary>
    [JsonIgnore]
    public required byte[] File { get; set; }

    /// <summary>Gets or sets the uploaded file name. It must end in <c>.html</c> or <c>.htm</c>.</summary>
    [JsonIgnore]
    public string FileName { get; set; } = "template.html";
}
