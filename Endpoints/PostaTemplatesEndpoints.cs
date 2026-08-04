namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Templates API area.</summary>
public interface IPostaTemplatesEndpoints
{
    /// <summary>Delete localization</summary>
        PostaEndpoint DeleteLocalization { get; }

    /// <summary>Update localization</summary>
        PostaEndpoint UpdateLocalization { get; }

    /// <summary>List stylesheets</summary>
        PostaEndpoint ListStylesheets { get; }

    /// <summary>Create stylesheet</summary>
        PostaEndpoint CreateStylesheet { get; }

    /// <summary>Delete stylesheet</summary>
        PostaEndpoint DeleteStylesheet { get; }

    /// <summary>Update stylesheet</summary>
        PostaEndpoint UpdateStylesheet { get; }

    /// <summary>List templates</summary>
        PostaEndpoint ListTemplates { get; }

    /// <summary>Create template</summary>
        PostaEndpoint CreateTemplate { get; }

    /// <summary>Import template</summary>
        PostaEndpoint ImportTemplate { get; }

    /// <summary>Import HTML template</summary>
        PostaEndpoint ImportHtmlTemplate { get; }

    /// <summary>Preview template</summary>
        PostaEndpoint PreviewTemplate { get; }

    /// <summary>Delete template</summary>
        PostaEndpoint DeleteTemplate { get; }

    /// <summary>Get template</summary>
        PostaEndpoint GetTemplate { get; }

    /// <summary>Update template</summary>
        PostaEndpoint UpdateTemplate { get; }

    /// <summary>Activate template version</summary>
        PostaEndpoint ActivateTemplateVersion { get; }

    /// <summary>Export template</summary>
        PostaEndpoint ExportTemplate { get; }

    /// <summary>Send test email</summary>
        PostaEndpoint SendTestEmail { get; }

    /// <summary>List template versions</summary>
        PostaEndpoint ListTemplateVersions { get; }

    /// <summary>Create template version</summary>
        PostaEndpoint CreateTemplateVersion { get; }

    /// <summary>Delete template version</summary>
        PostaEndpoint DeleteTemplateVersion { get; }

    /// <summary>Update template version</summary>
        PostaEndpoint UpdateTemplateVersion { get; }

    /// <summary>List localizations for a version</summary>
        PostaEndpoint ListLocalizationsForAVersion { get; }

    /// <summary>Create localization</summary>
        PostaEndpoint CreateLocalization { get; }

    /// <summary>Preview localized template</summary>
        PostaEndpoint PreviewLocalizedTemplate { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint DeleteLocalization { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/localizations/{localizationId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateLocalization { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/localizations/{localizationId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListStylesheets { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/stylesheets", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateStylesheet { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/stylesheets", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteStylesheet { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/stylesheets/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateStylesheet { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/stylesheets/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListTemplates { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ImportTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/import", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ImportHtmlTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/import-html", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint PreviewTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/preview", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteTemplate { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/templates/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetTemplate { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateTemplate { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/templates/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ActivateTemplateVersion { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/activate/{versionId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ExportTemplate { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates/{id}/export", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint SendTestEmail { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/send-test", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListTemplateVersions { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates/{id}/versions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateTemplateVersion { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/versions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteTemplateVersion { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateTemplateVersion { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListLocalizationsForAVersion { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}/localizations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateLocalization { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}/localizations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint PreviewLocalizedTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}/preview", PostaAuthentication.AccessToken);
}
