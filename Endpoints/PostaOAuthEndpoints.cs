namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the OAuth API area.</summary>
public interface IPostaOAuthEndpoints
{
    /// <summary>Discover SSO provider by email</summary>
        PostaEndpoint DiscoverSsoProviderByEmail { get; }

    /// <summary>List OAuth providers</summary>
        PostaEndpoint ListOauthProviders { get; }

    /// <summary>Initiate OAuth flow</summary>
        PostaEndpoint InitiateOauthFlow { get; }

    /// <summary>List linked OAuth accounts</summary>
        PostaEndpoint ListLinkedOauthAccounts { get; }

    /// <summary>Unlink OAuth account</summary>
        PostaEndpoint UnlinkOauthAccount { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint DiscoverSsoProviderByEmail { get; } = new(HttpMethod.Post, "/api/v1/auth/oauth/discover", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint ListOauthProviders { get; } = new(HttpMethod.Get, "/api/v1/auth/oauth/providers", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint InitiateOauthFlow { get; } = new(HttpMethod.Get, "/api/v1/auth/oauth/{provider}/authorize", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint ListLinkedOauthAccounts { get; } = new(HttpMethod.Get, "/api/v1/users/me/oauth", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UnlinkOauthAccount { get; } = new(HttpMethod.Delete, "/api/v1/users/me/oauth/{provider_id}", PostaAuthentication.AccessToken);
}
