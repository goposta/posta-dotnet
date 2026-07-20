using System.Text.Json.Serialization;

namespace Posta.Models.Workspaces;

/// <summary>Represents the ImportWorkspaceDataRequest payload.</summary>
public class ImportWorkspaceDataRequest
{
    /// <summary>Gets or sets <c>contact_lists</c>.</summary>
    [JsonPropertyName("contact_lists")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestContactListsItem>? ContactLists { get; set; }

    /// <summary>Gets or sets <c>contacts</c>.</summary>
    [JsonPropertyName("contacts")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestContactsItem>? Contacts { get; set; }

    /// <summary>Gets or sets <c>domains</c>.</summary>
    [JsonPropertyName("domains")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestDomainsItem>? Domains { get; set; }

    /// <summary>Gets or sets <c>exported_at</c>.</summary>
    [JsonPropertyName("exported_at")]
    public string? ExportedAt { get; set; }

    /// <summary>Gets or sets <c>languages</c>.</summary>
    [JsonPropertyName("languages")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestLanguagesItem>? Languages { get; set; }

    /// <summary>Gets or sets <c>posta_version</c>.</summary>
    [JsonPropertyName("posta_version")]
    public string? PostaVersion { get; set; }

    /// <summary>Gets or sets <c>smtp_servers</c>.</summary>
    [JsonPropertyName("smtp_servers")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestSmtpServersItem>? SmtpServers { get; set; }

    /// <summary>Gets or sets <c>stylesheets</c>.</summary>
    [JsonPropertyName("stylesheets")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestStylesheetsItem>? Stylesheets { get; set; }

    /// <summary>Gets or sets <c>subscriber_lists</c>.</summary>
    [JsonPropertyName("subscriber_lists")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestSubscriberListsItem>? SubscriberLists { get; set; }

    /// <summary>Gets or sets <c>subscribers</c>.</summary>
    [JsonPropertyName("subscribers")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestSubscribersItem>? Subscribers { get; set; }

    /// <summary>Gets or sets <c>suppressions</c>.</summary>
    [JsonPropertyName("suppressions")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestSuppressionsItem>? Suppressions { get; set; }

    /// <summary>Gets or sets <c>templates</c>.</summary>
    [JsonPropertyName("templates")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestTemplatesItem>? Templates { get; set; }

    /// <summary>Gets or sets <c>webhooks</c>.</summary>
    [JsonPropertyName("webhooks")]
    public IReadOnlyList<Shared.ImportWorkspaceDataRequestWebhooksItem>? Webhooks { get; set; }

    /// <summary>Gets or sets <c>workspace_settings</c>.</summary>
    [JsonPropertyName("workspace_settings")]
    public Shared.ImportWorkspaceDataRequestWorkspaceSettings? WorkspaceSettings { get; set; }

    /// <summary>Gets or sets the <c>X-Posta-Workspace-Id</c> header parameter.</summary>
    [JsonIgnore]
    public required int XPostaWorkspaceId { get; set; }

}