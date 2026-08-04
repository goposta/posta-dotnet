namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Subscribers API area.</summary>
public interface IPostaSubscribersEndpoints
{
    /// <summary>List subscribers</summary>
        PostaEndpoint ListSubscribers { get; }

    /// <summary>Create subscriber</summary>
        PostaEndpoint CreateSubscriber { get; }

    /// <summary>Bulk import subscribers (CSV)</summary>
        PostaEndpoint BulkImportSubscribersCsv { get; }

    /// <summary>Bulk import subscribers (JSON)</summary>
        PostaEndpoint BulkImportSubscribersJson { get; }

    /// <summary>Delete subscriber</summary>
        PostaEndpoint DeleteSubscriber { get; }

    /// <summary>Get subscriber</summary>
        PostaEndpoint GetSubscriber { get; }

    /// <summary>Update subscriber</summary>
        PostaEndpoint UpdateSubscriber { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint ListSubscribers { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscribers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateSubscriber { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscribers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint BulkImportSubscribersCsv { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscribers/import/csv", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint BulkImportSubscribersJson { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscribers/import/json", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteSubscriber { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/subscribers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetSubscriber { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscribers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateSubscriber { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/subscribers/{id}", PostaAuthentication.AccessToken);
}
