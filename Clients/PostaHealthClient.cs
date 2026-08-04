using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Health API area.</summary>
public sealed partial class PostaHealthClient : PostaSectionClient
{
    private readonly IPostaHealthEndpoints _endpoints;

    internal PostaHealthClient(PostaTransport transport, IPostaHealthEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
