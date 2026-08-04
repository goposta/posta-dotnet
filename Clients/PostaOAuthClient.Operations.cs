using Posta.Transport;
using OAuth = Posta.Models.OAuth;

namespace Posta.Clients;

public sealed partial class PostaOAuthClient
{
    public Task<OAuth.InitiateOauthFlowResponse?> InitiateOauthFlowAsync(OAuth.InitiateOauthFlowRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["provider"] = request?.Provider,
            },
        };

        return SendAsync<OAuth.InitiateOauthFlowResponse>(_endpoints.InitiateOauthFlow, postaRequest, cancellationToken);
    }
    public Task<OAuth.ListOauthProvidersResponse?> ListOauthProvidersAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<OAuth.ListOauthProvidersResponse>(_endpoints.ListOauthProviders, null, cancellationToken);
    }
    public Task<OAuth.DiscoverSsoProviderByEmailResponse?> DiscoverSsoProviderByEmailAsync(OAuth.DiscoverSsoProviderByEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<OAuth.DiscoverSsoProviderByEmailResponse>(_endpoints.DiscoverSsoProviderByEmail, postaRequest, cancellationToken);
    }
    public Task<OAuth.UnlinkOauthAccountResponse?> UnlinkOauthAccountAsync(OAuth.UnlinkOauthAccountRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["provider_id"] = request?.ProviderId,
            },
        };

        return SendAsync<OAuth.UnlinkOauthAccountResponse>(_endpoints.UnlinkOauthAccount, postaRequest, cancellationToken);
    }
    public Task<OAuth.ListLinkedOauthAccountsResponse?> ListLinkedOauthAccountsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<OAuth.ListLinkedOauthAccountsResponse>(_endpoints.ListLinkedOauthAccounts, null, cancellationToken);
    }
}




