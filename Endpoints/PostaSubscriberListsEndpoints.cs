namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the SubscriberLists API area.</summary>
public interface IPostaSubscriberListsEndpoints
{
    /// <summary>Subscribe an email to a list</summary>
        PostaEndpoint SubscribeAnEmailToAList { get; }

    /// <summary>Re-subscribe an email to a list</summary>
        PostaEndpoint ReSubscribeAnEmailToAList { get; }

    /// <summary>Unsubscribe an email from a list</summary>
        PostaEndpoint UnsubscribeAnEmailFromAList { get; }

    /// <summary>List subscriber lists</summary>
        PostaEndpoint ListSubscriberLists { get; }

    /// <summary>Create subscriber list</summary>
        PostaEndpoint CreateSubscriberList { get; }

    /// <summary>Preview segment count</summary>
        PostaEndpoint PreviewSegmentCount { get; }

    /// <summary>Delete subscriber list</summary>
        PostaEndpoint DeleteSubscriberList { get; }

    /// <summary>Get subscriber list</summary>
        PostaEndpoint GetSubscriberList { get; }

    /// <summary>Update subscriber list</summary>
        PostaEndpoint UpdateSubscriberList { get; }

    /// <summary>Remove subscriber from list</summary>
        PostaEndpoint RemoveSubscriberFromList { get; }

    /// <summary>List members of subscriber list</summary>
        PostaEndpoint ListMembersOfSubscriberList { get; }

    /// <summary>Add subscriber to list</summary>
        PostaEndpoint AddSubscriberToList { get; }

    /// <summary>Re-subscribe an email to a list</summary>
        PostaEndpoint ReSubscribeAnEmailToAListSubscriberLists { get; }

    /// <summary>Unsubscribe an email from a list</summary>
        PostaEndpoint UnsubscribeAnEmailFromAListSubscriberLists { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint SubscribeAnEmailToAList { get; } = new(HttpMethod.Post, "/api/v1/subscriber-lists/subscribe", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint ReSubscribeAnEmailToAList { get; } = new(HttpMethod.Post, "/api/v1/subscriber-lists/{id}/resubscribe", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint UnsubscribeAnEmailFromAList { get; } = new(HttpMethod.Post, "/api/v1/subscriber-lists/{id}/unsubscribe", PostaAuthentication.ApiKey);

    /// <inheritdoc />
        public virtual PostaEndpoint ListSubscriberLists { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscriber-lists", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateSubscriberList { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint PreviewSegmentCount { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists/preview-segment", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteSubscriberList { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/subscriber-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetSubscriberList { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscriber-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateSubscriberList { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/subscriber-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint RemoveSubscriberFromList { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/subscriber-lists/{id}/members", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListMembersOfSubscriberList { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscriber-lists/{id}/members", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint AddSubscriberToList { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists/{id}/members", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ReSubscribeAnEmailToAListSubscriberLists { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists/{id}/resubscribe", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UnsubscribeAnEmailFromAListSubscriberLists { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists/{id}/unsubscribe", PostaAuthentication.AccessToken);
}
