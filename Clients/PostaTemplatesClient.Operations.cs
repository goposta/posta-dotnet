using Posta.Transport;
using Templates = Posta.Models.Templates;

namespace Posta.Clients;

public sealed partial class PostaTemplatesClient
{
    public Task<Templates.DeleteStylesheetResponse?> DeleteStylesheetAsync(Templates.DeleteStylesheetRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.DeleteStylesheetResponse>(_endpoints.DeleteStylesheet, postaRequest, cancellationToken);
    }
    public Task<Templates.ListLocalizationsForAVersionResponse?> ListLocalizationsForAVersionAsync(Templates.ListLocalizationsForAVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.ListLocalizationsForAVersionResponse>(_endpoints.ListLocalizationsForAVersion, postaRequest, cancellationToken);
    }
    public Task<Templates.CreateStylesheetResponse?> CreateStylesheetAsync(Templates.CreateStylesheetRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Templates.CreateStylesheetResponse>(_endpoints.CreateStylesheet, postaRequest, cancellationToken);
    }
    public Task<Templates.ListStylesheetsResponse?> ListStylesheetsAsync(Templates.ListStylesheetsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["q"] = request?.Q,
                ["sort"] = request?.Sort,
            },
        };

        return SendAsync<Templates.ListStylesheetsResponse>(_endpoints.ListStylesheets, postaRequest, cancellationToken);
    }
    public Task<Templates.ImportTemplateResponse?> ImportTemplateAsync(Templates.ImportTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Templates.ImportTemplateResponse>(_endpoints.ImportTemplate, postaRequest, cancellationToken);
    }
    public Task<Templates.ImportHtmlTemplateResponse?> ImportHtmlTemplateAsync(Templates.ImportHtmlTemplateRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        var content = new MultipartFormDataContent();
        var file = new ByteArrayContent(request.File);
        file.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue("text/html");
        content.Add(file, "file", request.FileName);
        return SendAsync<Templates.ImportHtmlTemplateResponse>(_endpoints.ImportHtmlTemplate, new PostaRequest { Content = content }, cancellationToken);
    }
    public Task<Templates.DeleteTemplateResponse?> DeleteTemplateAsync(Templates.DeleteTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.DeleteTemplateResponse>(_endpoints.DeleteTemplate, postaRequest, cancellationToken);
    }
    public Task<Templates.ListTemplatesResponse?> ListTemplatesAsync(Templates.ListTemplatesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Templates.ListTemplatesResponse>(_endpoints.ListTemplates, postaRequest, cancellationToken);
    }
    public Task<Templates.ActivateTemplateVersionResponse?> ActivateTemplateVersionAsync(Templates.ActivateTemplateVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.ActivateTemplateVersionResponse>(_endpoints.ActivateTemplateVersion, postaRequest, cancellationToken);
    }
    public Task<Templates.UpdateTemplateResponse?> UpdateTemplateAsync(Templates.UpdateTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.UpdateTemplateResponse>(_endpoints.UpdateTemplate, postaRequest, cancellationToken);
    }
    public Task<Templates.ExportTemplateResponse?> ExportTemplateAsync(Templates.ExportTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.ExportTemplateResponse>(_endpoints.ExportTemplate, postaRequest, cancellationToken);
    }
    public Task<Templates.UpdateStylesheetResponse?> UpdateStylesheetAsync(Templates.UpdateStylesheetRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.UpdateStylesheetResponse>(_endpoints.UpdateStylesheet, postaRequest, cancellationToken);
    }
    public Task<Templates.CreateLocalizationResponse?> CreateLocalizationAsync(Templates.CreateLocalizationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.CreateLocalizationResponse>(_endpoints.CreateLocalization, postaRequest, cancellationToken);
    }
    public Task<Templates.DeleteTemplateVersionResponse?> DeleteTemplateVersionAsync(Templates.DeleteTemplateVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.DeleteTemplateVersionResponse>(_endpoints.DeleteTemplateVersion, postaRequest, cancellationToken);
    }
    public Task<Templates.UpdateLocalizationResponse?> UpdateLocalizationAsync(Templates.UpdateLocalizationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["localizationId"] = request?.LocalizationId,
            },
        };

        return SendAsync<Templates.UpdateLocalizationResponse>(_endpoints.UpdateLocalization, postaRequest, cancellationToken);
    }
    public Task<Templates.CreateTemplateResponse?> CreateTemplateAsync(Templates.CreateTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Templates.CreateTemplateResponse>(_endpoints.CreateTemplate, postaRequest, cancellationToken);
    }
    public Task<Templates.GetTemplateResponse?> GetTemplateAsync(Templates.GetTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.GetTemplateResponse>(_endpoints.GetTemplate, postaRequest, cancellationToken);
    }
    public Task<Templates.SendTestEmailResponse?> SendTestEmailAsync(Templates.SendTestEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.SendTestEmailResponse>(_endpoints.SendTestEmail, postaRequest, cancellationToken);
    }
    public Task<Templates.CreateTemplateVersionResponse?> CreateTemplateVersionAsync(Templates.CreateTemplateVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.CreateTemplateVersionResponse>(_endpoints.CreateTemplateVersion, postaRequest, cancellationToken);
    }
    public Task<Templates.ListTemplateVersionsResponse?> ListTemplateVersionsAsync(Templates.ListTemplateVersionsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.ListTemplateVersionsResponse>(_endpoints.ListTemplateVersions, postaRequest, cancellationToken);
    }
    public Task<Templates.DeleteLocalizationResponse?> DeleteLocalizationAsync(Templates.DeleteLocalizationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["localizationId"] = request?.LocalizationId,
            },
        };

        return SendAsync<Templates.DeleteLocalizationResponse>(_endpoints.DeleteLocalization, postaRequest, cancellationToken);
    }
    public Task<Templates.PreviewLocalizedTemplateResponse?> PreviewLocalizedTemplateAsync(Templates.PreviewLocalizedTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.PreviewLocalizedTemplateResponse>(_endpoints.PreviewLocalizedTemplate, postaRequest, cancellationToken);
    }
    public Task<Templates.PreviewTemplateResponse?> PreviewTemplateAsync(Templates.PreviewTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Templates.PreviewTemplateResponse>(_endpoints.PreviewTemplate, postaRequest, cancellationToken);
    }
    public Task<Templates.UpdateTemplateVersionResponse?> UpdateTemplateVersionAsync(Templates.UpdateTemplateVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.UpdateTemplateVersionResponse>(_endpoints.UpdateTemplateVersion, postaRequest, cancellationToken);
    }
}




