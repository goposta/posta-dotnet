using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the UnsubscribeLists API area.</summary>
public sealed partial class PostaUnsubscribeListsClient : PostaSectionClient
{
    private readonly IPostaUnsubscribeListsEndpoints _endpoints;

    internal PostaUnsubscribeListsClient(PostaTransport transport, IPostaUnsubscribeListsEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
