using Posta.Transport;
using Campaigns = Posta.Models.Campaigns;

namespace Posta.Clients;

public sealed partial class PostaCampaignsClient
{
    public Task<Campaigns.DeleteCampaignResponse?> DeleteCampaignAsync(Campaigns.DeleteCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.DeleteCampaignResponse>(_endpoints.DeleteCampaign, postaRequest, cancellationToken);
    }
    public Task<Campaigns.DuplicateCampaignResponse?> DuplicateCampaignAsync(Campaigns.DuplicateCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.DuplicateCampaignResponse>(_endpoints.DuplicateCampaign, postaRequest, cancellationToken);
    }
    public Task<Campaigns.ListCampaignMessagesResponse?> ListCampaignMessagesAsync(Campaigns.ListCampaignMessagesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<Campaigns.ListCampaignMessagesResponse>(_endpoints.ListCampaignMessages, postaRequest, cancellationToken);
    }
    public Task<Campaigns.ResumeCampaignResponse?> ResumeCampaignAsync(Campaigns.ResumeCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.ResumeCampaignResponse>(_endpoints.ResumeCampaign, postaRequest, cancellationToken);
    }
    public Task<Campaigns.ListCampaignsResponse?> ListCampaignsAsync(Campaigns.ListCampaignsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<Campaigns.ListCampaignsResponse>(_endpoints.ListCampaigns, postaRequest, cancellationToken);
    }
    public Task<Campaigns.GetCampaignResponse?> GetCampaignAsync(Campaigns.GetCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.GetCampaignResponse>(_endpoints.GetCampaign, postaRequest, cancellationToken);
    }
    public Task<Campaigns.SendCampaignResponse?> SendCampaignAsync(Campaigns.SendCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.SendCampaignResponse>(_endpoints.SendCampaign, postaRequest, cancellationToken);
    }
    public Task<Campaigns.CreateCampaignResponse?> CreateCampaignAsync(Campaigns.CreateCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Campaigns.CreateCampaignResponse>(_endpoints.CreateCampaign, postaRequest, cancellationToken);
    }
    public Task<Campaigns.GetCampaignAnalyticsResponse?> GetCampaignAnalyticsAsync(Campaigns.GetCampaignAnalyticsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.GetCampaignAnalyticsResponse>(_endpoints.GetCampaignAnalytics, postaRequest, cancellationToken);
    }
    public Task<Campaigns.UpdateCampaignResponse?> UpdateCampaignAsync(Campaigns.UpdateCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.UpdateCampaignResponse>(_endpoints.UpdateCampaign, postaRequest, cancellationToken);
    }
    public Task<Campaigns.CancelCampaignResponse?> CancelCampaignAsync(Campaigns.CancelCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.CancelCampaignResponse>(_endpoints.CancelCampaign, postaRequest, cancellationToken);
    }
    public Task<Campaigns.PauseCampaignResponse?> PauseCampaignAsync(Campaigns.PauseCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.PauseCampaignResponse>(_endpoints.PauseCampaign, postaRequest, cancellationToken);
    }
}




