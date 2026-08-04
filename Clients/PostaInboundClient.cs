using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Inbound API area.</summary>
public sealed partial class PostaInboundClient : PostaSectionClient
{
    private readonly IPostaInboundEndpoints _endpoints;

    internal PostaInboundClient(PostaTransport transport, IPostaInboundEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
