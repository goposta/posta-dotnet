using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Campaigns API area.</summary>
public sealed partial class PostaCampaignsClient : PostaSectionClient
{
    private readonly IPostaCampaignsEndpoints _endpoints;

    internal PostaCampaignsClient(PostaTransport transport, IPostaCampaignsEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
