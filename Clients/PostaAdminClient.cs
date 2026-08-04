using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Admin API area.</summary>
public sealed partial class PostaAdminClient : PostaSectionClient
{
    private readonly IPostaAdminEndpoints _endpoints;

    internal PostaAdminClient(PostaTransport transport, IPostaAdminEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
