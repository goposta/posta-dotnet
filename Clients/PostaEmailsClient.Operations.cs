using Posta.Transport;
using Emails = Posta.Models.Emails;

namespace Posta.Clients;

public sealed partial class PostaEmailsClient
{
    public Task<Emails.GetEmailDeliveryStatusResponse?> GetEmailDeliveryStatusAsync(Emails.GetEmailDeliveryStatusRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.GetEmailDeliveryStatusResponse>(_endpoints.GetEmailDeliveryStatus, postaRequest, cancellationToken);
    }
    public Task<Emails.GetEmailDeliveryStatusWorkspaceResourcesResponse?> GetEmailDeliveryStatusWorkspaceResourcesAsync(Emails.GetEmailDeliveryStatusWorkspaceResourcesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.GetEmailDeliveryStatusWorkspaceResourcesResponse>(_endpoints.GetEmailDeliveryStatusWorkspaceResources, postaRequest, cancellationToken);
    }
    public Task<Emails.PreviewEmailFromTemplateWorkspaceResourcesResponse?> PreviewEmailFromTemplateWorkspaceResourcesAsync(Emails.PreviewEmailFromTemplateWorkspaceResourcesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Emails.PreviewEmailFromTemplateWorkspaceResourcesResponse>(_endpoints.PreviewEmailFromTemplateWorkspaceResources, postaRequest, cancellationToken);
    }
    public Task<Emails.PreviewEmailFromTemplateResponse?> PreviewEmailFromTemplateAsync(Emails.PreviewEmailFromTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Emails.PreviewEmailFromTemplateResponse>(_endpoints.PreviewEmailFromTemplate, postaRequest, cancellationToken);
    }
    public Task<Emails.ListEmailsResponse?> ListEmailsAsync(Emails.ListEmailsRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<Emails.ListEmailsResponse>(_endpoints.ListEmails, postaRequest, cancellationToken);
    }
    public Task<Emails.ListBouncesResponse?> ListBouncesAsync(Emails.ListBouncesRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<Emails.ListBouncesResponse>(_endpoints.ListBounces, postaRequest, cancellationToken);
    }
    public Task<Emails.GetEmailDetailsWorkspaceResourcesResponse?> GetEmailDetailsWorkspaceResourcesAsync(Emails.GetEmailDetailsWorkspaceResourcesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.GetEmailDetailsWorkspaceResourcesResponse>(_endpoints.GetEmailDetailsWorkspaceResources, postaRequest, cancellationToken);
    }
    public Task<Emails.SendAnEmailResponse?> SendAnEmailAsync(Emails.SendAnEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Query = new Dictionary<string, object?>
            {
                ["dry_run"] = request?.DryRun,
            },
        };

        return SendAsync<Emails.SendAnEmailResponse>(_endpoints.SendAnEmail, postaRequest, cancellationToken);
    }
    public Task<Emails.VerifyAnEmailAddressResponse?> VerifyAnEmailAddressAsync(Emails.VerifyAnEmailAddressRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Query = new Dictionary<string, object?>
            {
                ["fresh"] = request?.Fresh,
            },
        };

        return SendAsync<Emails.VerifyAnEmailAddressResponse>(_endpoints.VerifyAnEmailAddress, postaRequest, cancellationToken);
    }
    public Task<Emails.SendBatchEmailsResponse?> SendBatchEmailsAsync(Emails.SendBatchEmailsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Query = new Dictionary<string, object?>
            {
                ["dry_run"] = request?.DryRun,
            },
        };

        return SendAsync<Emails.SendBatchEmailsResponse>(_endpoints.SendBatchEmails, postaRequest, cancellationToken);
    }
    public Task<Emails.SendEmailUsingTemplateResponse?> SendEmailUsingTemplateAsync(Emails.SendEmailUsingTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Query = new Dictionary<string, object?>
            {
                ["dry_run"] = request?.DryRun,
            },
        };

        return SendAsync<Emails.SendEmailUsingTemplateResponse>(_endpoints.SendEmailUsingTemplate, postaRequest, cancellationToken);
    }
    public Task<Emails.RetryFailedEmailResponse?> RetryFailedEmailAsync(Emails.RetryFailedEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.RetryFailedEmailResponse>(_endpoints.RetryFailedEmail, postaRequest, cancellationToken);
    }
    public Task<Emails.RetryFailedEmailWorkspaceResourcesResponse?> RetryFailedEmailWorkspaceResourcesAsync(Emails.RetryFailedEmailWorkspaceResourcesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.RetryFailedEmailWorkspaceResourcesResponse>(_endpoints.RetryFailedEmailWorkspaceResources, postaRequest, cancellationToken);
    }
    public Task<Emails.GetEmailDetailsResponse?> GetEmailDetailsAsync(Emails.GetEmailDetailsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.GetEmailDetailsResponse>(_endpoints.GetEmailDetails, postaRequest, cancellationToken);
    }
    public Task<Emails.ListEmailsWorkspaceResourcesResponse?> ListEmailsWorkspaceResourcesAsync(Emails.ListEmailsWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<Emails.ListEmailsWorkspaceResourcesResponse>(_endpoints.ListEmailsWorkspaceResources, postaRequest, cancellationToken);
    }
}




