using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Webhooks API area.</summary>
public sealed partial class PostaWebhooksClient : PostaSectionClient
{
    private readonly IPostaWebhooksEndpoints _endpoints;

    internal PostaWebhooksClient(PostaTransport transport, IPostaWebhooksEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
