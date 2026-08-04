namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Webhooks API area.</summary>
public interface IPostaWebhooksEndpoints
{
    /// <summary>List webhook deliveries</summary>
        PostaEndpoint ListWebhookDeliveries { get; }

    /// <summary>List webhooks</summary>
        PostaEndpoint ListWebhooks { get; }

    /// <summary>Create webhook</summary>
        PostaEndpoint CreateWebhook { get; }

    /// <summary>Bounce notification webhook</summary>
        PostaEndpoint BounceNotificationWebhook { get; }

    /// <summary>Delete webhook</summary>
        PostaEndpoint DeleteWebhook { get; }

    /// <summary>List webhook deliveries</summary>
        PostaEndpoint ListWebhookDeliveriesWorkspaceResources { get; }

    /// <summary>List webhooks</summary>
        PostaEndpoint ListWebhooksWorkspaceResources { get; }

    /// <summary>Create webhook</summary>
        PostaEndpoint CreateWebhookUser { get; }

    /// <summary>Delete webhook</summary>
        PostaEndpoint DeleteWebhookUser { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint ListWebhookDeliveries { get; } = new(HttpMethod.Get, "/api/v1/webhook-deliveries", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint ListWebhooks { get; } = new(HttpMethod.Get, "/api/v1/webhooks", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateWebhook { get; } = new(HttpMethod.Post, "/api/v1/webhooks", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint BounceNotificationWebhook { get; } = new(HttpMethod.Post, "/api/v1/webhooks/bounce", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteWebhook { get; } = new(HttpMethod.Delete, "/api/v1/webhooks/{id}", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint ListWebhookDeliveriesWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/webhook-deliveries", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListWebhooksWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/webhooks", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateWebhookUser { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/webhooks", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteWebhookUser { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/webhooks/{id}", PostaAuthentication.AccessToken);
}
