namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the UnsubscribeLists API area.</summary>
public interface IPostaUnsubscribeListsEndpoints
{
    /// <summary>List unsubscribe lists</summary>
        PostaEndpoint ListUnsubscribeLists { get; }

    /// <summary>Create unsubscribe list</summary>
        PostaEndpoint CreateUnsubscribeList { get; }

    /// <summary>Delete unsubscribe list</summary>
        PostaEndpoint DeleteUnsubscribeList { get; }

    /// <summary>Get unsubscribe list</summary>
        PostaEndpoint GetUnsubscribeList { get; }

    /// <summary>Update unsubscribe list</summary>
        PostaEndpoint UpdateUnsubscribeList { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint ListUnsubscribeLists { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/unsubscribe-lists", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateUnsubscribeList { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/unsubscribe-lists", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteUnsubscribeList { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/unsubscribe-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetUnsubscribeList { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/unsubscribe-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateUnsubscribeList { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/unsubscribe-lists/{id}", PostaAuthentication.AccessToken);
}
