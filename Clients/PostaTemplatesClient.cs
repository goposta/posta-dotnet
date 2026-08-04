using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Templates API area.</summary>
public sealed partial class PostaTemplatesClient : PostaSectionClient
{
    private readonly IPostaTemplatesEndpoints _endpoints;

    internal PostaTemplatesClient(PostaTransport transport, IPostaTemplatesEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
