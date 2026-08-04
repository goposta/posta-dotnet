using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Subscribers API area.</summary>
public sealed partial class PostaSubscribersClient : PostaSectionClient
{
    private readonly IPostaSubscribersEndpoints _endpoints;

    internal PostaSubscribersClient(PostaTransport transport, IPostaSubscribersEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
