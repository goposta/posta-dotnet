using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the OAuth API area.</summary>
public sealed partial class PostaOAuthClient : PostaSectionClient
{
    private readonly IPostaOAuthEndpoints _endpoints;

    internal PostaOAuthClient(PostaTransport transport, IPostaOAuthEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
