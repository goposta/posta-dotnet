using Posta.Transport;
using WorkspaceResources = Posta.Models.WorkspaceResources;

namespace Posta.Clients;

public sealed partial class PostaWorkspaceResourcesClient
{
    public Task<WorkspaceResources.ListContactsResponse?> ListContactsAsync(WorkspaceResources.ListContactsRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<WorkspaceResources.ListContactsResponse>(_endpoints.ListContacts, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.ListSmtpServersResponse?> ListSmtpServersAsync(WorkspaceResources.ListSmtpServersRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<WorkspaceResources.ListSmtpServersResponse>(_endpoints.ListSmtpServers, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.VerifyDomainDnsRecordsResponse?> VerifyDomainDnsRecordsAsync(WorkspaceResources.VerifyDomainDnsRecordsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.VerifyDomainDnsRecordsResponse>(_endpoints.VerifyDomainDnsRecords, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.GetContactDetailsResponse?> GetContactDetailsAsync(WorkspaceResources.GetContactDetailsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.GetContactDetailsResponse>(_endpoints.GetContactDetails, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.DeliverabilityByProviderResponse?> DeliverabilityByProviderAsync(WorkspaceResources.DeliverabilityByProviderRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
            },
        };

        return SendAsync<WorkspaceResources.DeliverabilityByProviderResponse>(_endpoints.DeliverabilityByProvider, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.AddDomainResponse?> AddDomainAsync(WorkspaceResources.AddDomainRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.AddDomainResponse>(_endpoints.AddDomain, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.AddSmtpServerResponse?> AddSmtpServerAsync(WorkspaceResources.AddSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.AddSmtpServerResponse>(_endpoints.AddSmtpServer, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.GetApiKeyResponse?> GetApiKeyAsync(WorkspaceResources.GetApiKeyRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.GetApiKeyResponse>(_endpoints.GetApiKey, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.UpdateLanguageResponse?> UpdateLanguageAsync(WorkspaceResources.UpdateLanguageRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.UpdateLanguageResponse>(_endpoints.UpdateLanguage, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.DeleteLanguageResponse?> DeleteLanguageAsync(WorkspaceResources.DeleteLanguageRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.DeleteLanguageResponse>(_endpoints.DeleteLanguage, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.UpdateSmtpServerResponse?> UpdateSmtpServerAsync(WorkspaceResources.UpdateSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.UpdateSmtpServerResponse>(_endpoints.UpdateSmtpServer, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.GetSmtpServerResponse?> GetSmtpServerAsync(WorkspaceResources.GetSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.GetSmtpServerResponse>(_endpoints.GetSmtpServer, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.GetDashboardStatisticsResponse?> GetDashboardStatisticsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<WorkspaceResources.GetDashboardStatisticsResponse>(_endpoints.GetDashboardStatistics, null, cancellationToken);
    }
    public Task<WorkspaceResources.DashboardAnalyticsResponse?> DashboardAnalyticsAsync(WorkspaceResources.DashboardAnalyticsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
            },
        };

        return SendAsync<WorkspaceResources.DashboardAnalyticsResponse>(_endpoints.DashboardAnalytics, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.TestSmtpServerConnectionResponse?> TestSmtpServerConnectionAsync(WorkspaceResources.TestSmtpServerConnectionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.TestSmtpServerConnectionResponse>(_endpoints.TestSmtpServerConnection, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.DeleteSmtpServerResponse?> DeleteSmtpServerAsync(WorkspaceResources.DeleteSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.DeleteSmtpServerResponse>(_endpoints.DeleteSmtpServer, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.RecordABounceResponse?> RecordABounceAsync(WorkspaceResources.RecordABounceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.RecordABounceResponse>(_endpoints.RecordABounce, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.DeleteDomainResponse?> DeleteDomainAsync(WorkspaceResources.DeleteDomainRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.DeleteDomainResponse>(_endpoints.DeleteDomain, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.RemoveFromSuppressionListResponse?> RemoveFromSuppressionListAsync(WorkspaceResources.RemoveFromSuppressionListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.RemoveFromSuppressionListResponse>(_endpoints.RemoveFromSuppressionList, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.ListLanguagesResponse?> ListLanguagesAsync(WorkspaceResources.ListLanguagesRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<WorkspaceResources.ListLanguagesResponse>(_endpoints.ListLanguages, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.CreateApiKeyResponse?> CreateApiKeyAsync(WorkspaceResources.CreateApiKeyRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.CreateApiKeyResponse>(_endpoints.CreateApiKey, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.EmailAnalyticsResponse?> EmailAnalyticsAsync(WorkspaceResources.EmailAnalyticsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<WorkspaceResources.EmailAnalyticsResponse>(_endpoints.EmailAnalytics, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.CreateLanguageResponse?> CreateLanguageAsync(WorkspaceResources.CreateLanguageRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.CreateLanguageResponse>(_endpoints.CreateLanguage, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.AddToSuppressionListResponse?> AddToSuppressionListAsync(WorkspaceResources.AddToSuppressionListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.AddToSuppressionListResponse>(_endpoints.AddToSuppressionList, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.GetDomainDetailsResponse?> GetDomainDetailsAsync(WorkspaceResources.GetDomainDetailsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.GetDomainDetailsResponse>(_endpoints.GetDomainDetails, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.ListDomainsResponse?> ListDomainsAsync(WorkspaceResources.ListDomainsRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<WorkspaceResources.ListDomainsResponse>(_endpoints.ListDomains, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.ListApiKeysResponse?> ListApiKeysAsync(WorkspaceResources.ListApiKeysRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<WorkspaceResources.ListApiKeysResponse>(_endpoints.ListApiKeys, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.DeleteApiKeyResponse?> DeleteApiKeyAsync(WorkspaceResources.DeleteApiKeyRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.DeleteApiKeyResponse>(_endpoints.DeleteApiKey, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.RevokeApiKeyResponse?> RevokeApiKeyAsync(WorkspaceResources.RevokeApiKeyRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.RevokeApiKeyResponse>(_endpoints.RevokeApiKey, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.ListSuppressedEmailsResponse?> ListSuppressedEmailsAsync(WorkspaceResources.ListSuppressedEmailsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["list_id"] = request?.ListId,
            },
        };

        return SendAsync<WorkspaceResources.ListSuppressedEmailsResponse>(_endpoints.ListSuppressedEmails, postaRequest, cancellationToken);
    }
    public Task<WorkspaceResources.ListBouncesWorkspaceResourcesResponse?> ListBouncesWorkspaceResourcesAsync(WorkspaceResources.ListBouncesWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<WorkspaceResources.ListBouncesWorkspaceResourcesResponse>(_endpoints.ListBouncesWorkspaceResources, postaRequest, cancellationToken);
    }
}




