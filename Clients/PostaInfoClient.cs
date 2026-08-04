using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Info API area.</summary>
public sealed partial class PostaInfoClient : PostaSectionClient
{
    private readonly IPostaInfoEndpoints _endpoints;

    internal PostaInfoClient(PostaTransport transport, IPostaInfoEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
