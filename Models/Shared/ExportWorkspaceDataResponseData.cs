using System.Text.Json.Serialization;

namespace Posta.Models.Shared;

/// <summary>Represents the ExportWorkspaceDataResponseData payload.</summary>
public class ExportWorkspaceDataResponseData
{
    /// <summary>Gets or sets <c>contact_lists</c>.</summary>
    [JsonPropertyName("contact_lists")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataContactListsItem>? ContactLists { get; set; }

    /// <summary>Gets or sets <c>contacts</c>.</summary>
    [JsonPropertyName("contacts")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataContactsItem>? Contacts { get; set; }

    /// <summary>Gets or sets <c>domains</c>.</summary>
    [JsonPropertyName("domains")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataDomainsItem>? Domains { get; set; }

    /// <summary>Gets or sets <c>exported_at</c>.</summary>
    [JsonPropertyName("exported_at")]
    public string? ExportedAt { get; set; }

    /// <summary>Gets or sets <c>languages</c>.</summary>
    [JsonPropertyName("languages")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataLanguagesItem>? Languages { get; set; }

    /// <summary>Gets or sets <c>posta_version</c>.</summary>
    [JsonPropertyName("posta_version")]
    public string? PostaVersion { get; set; }

    /// <summary>Gets or sets <c>smtp_servers</c>.</summary>
    [JsonPropertyName("smtp_servers")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataSmtpServersItem>? SmtpServers { get; set; }

    /// <summary>Gets or sets <c>stylesheets</c>.</summary>
    [JsonPropertyName("stylesheets")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataStylesheetsItem>? Stylesheets { get; set; }

    /// <summary>Gets or sets <c>subscriber_lists</c>.</summary>
    [JsonPropertyName("subscriber_lists")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataSubscriberListsItem>? SubscriberLists { get; set; }

    /// <summary>Gets or sets <c>subscribers</c>.</summary>
    [JsonPropertyName("subscribers")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataSubscribersItem>? Subscribers { get; set; }

    /// <summary>Gets or sets <c>suppressions</c>.</summary>
    [JsonPropertyName("suppressions")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataSuppressionsItem>? Suppressions { get; set; }

    /// <summary>Gets or sets <c>templates</c>.</summary>
    [JsonPropertyName("templates")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataTemplatesItem>? Templates { get; set; }

    /// <summary>Gets or sets <c>webhooks</c>.</summary>
    [JsonPropertyName("webhooks")]
    public IReadOnlyList<ExportWorkspaceDataResponseDataWebhooksItem>? Webhooks { get; set; }

    /// <summary>Gets or sets <c>workspace_settings</c>.</summary>
    [JsonPropertyName("workspace_settings")]
    public ExportWorkspaceDataResponseDataWorkspaceSettings? WorkspaceSettings { get; set; }

}