using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

internal sealed partial class PostaClientSection : PostaSectionClient,
    IPostaAuthClient, IPostaOAuthClient, IPostaUsersClient, IPostaWorkspacesClient, IPostaEmailsClient,
    IPostaTemplatesClient, IPostaCampaignsClient, IPostaSubscribersClient, IPostaSubscriberListsClient,
    IPostaUnsubscribeListsClient, IPostaInboundClient, IPostaWebhooksClient, IPostaWorkspaceResourcesClient,
    IPostaAdminClient, IPostaHealthClient, IPostaInfoClient
{
    private readonly IPostaEndpoints _endpoints;

    internal PostaClientSection(PostaTransport transport, IPostaEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}