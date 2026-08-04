using Posta.Transport;
using Webhooks = Posta.Models.Webhooks;

namespace Posta.Clients;

public sealed partial class PostaWebhooksClient
{
    public Task<Webhooks.ListWebhooksWorkspaceResourcesResponse?> ListWebhooksWorkspaceResourcesAsync(Webhooks.ListWebhooksWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<Webhooks.ListWebhooksWorkspaceResourcesResponse>(_endpoints.ListWebhooksWorkspaceResources, postaRequest, cancellationToken);
    }
    public Task<Webhooks.ListWebhookDeliveriesWorkspaceResourcesResponse?> ListWebhookDeliveriesWorkspaceResourcesAsync(Webhooks.ListWebhookDeliveriesWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<Webhooks.ListWebhookDeliveriesWorkspaceResourcesResponse>(_endpoints.ListWebhookDeliveriesWorkspaceResources, postaRequest, cancellationToken);
    }
    public Task<Webhooks.CreateWebhookUserResponse?> CreateWebhookUserAsync(Webhooks.CreateWebhookUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Webhooks.CreateWebhookUserResponse>(_endpoints.CreateWebhookUser, postaRequest, cancellationToken);
    }
    public Task<Webhooks.CreateWebhookResponse?> CreateWebhookAsync(Webhooks.CreateWebhookRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Webhooks.CreateWebhookResponse>(_endpoints.CreateWebhook, postaRequest, cancellationToken);
    }
    public Task<Webhooks.ListWebhooksResponse?> ListWebhooksAsync(Webhooks.ListWebhooksRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<Webhooks.ListWebhooksResponse>(_endpoints.ListWebhooks, postaRequest, cancellationToken);
    }
    public Task<Webhooks.ListWebhookDeliveriesResponse?> ListWebhookDeliveriesAsync(Webhooks.ListWebhookDeliveriesRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<Webhooks.ListWebhookDeliveriesResponse>(_endpoints.ListWebhookDeliveries, postaRequest, cancellationToken);
    }
    public Task<Webhooks.DeleteWebhookResponse?> DeleteWebhookAsync(Webhooks.DeleteWebhookRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Webhooks.DeleteWebhookResponse>(_endpoints.DeleteWebhook, postaRequest, cancellationToken);
    }
    public Task<Webhooks.DeleteWebhookUserResponse?> DeleteWebhookUserAsync(Webhooks.DeleteWebhookUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Webhooks.DeleteWebhookUserResponse>(_endpoints.DeleteWebhookUser, postaRequest, cancellationToken);
    }
    public Task<Webhooks.BounceNotificationWebhookResponse?> BounceNotificationWebhookAsync(Webhooks.BounceNotificationWebhookRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Webhooks.BounceNotificationWebhookResponse>(_endpoints.BounceNotificationWebhook, postaRequest, cancellationToken);
    }
}




