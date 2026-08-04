using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the SubscriberLists API area.</summary>
public sealed partial class PostaSubscriberListsClient : PostaSectionClient
{
    private readonly IPostaSubscriberListsEndpoints _endpoints;

    internal PostaSubscriberListsClient(PostaTransport transport, IPostaSubscriberListsEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
