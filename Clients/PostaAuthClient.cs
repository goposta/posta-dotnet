using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Auth API area.</summary>
public sealed partial class PostaAuthClient : PostaSectionClient
{
    private readonly IPostaAuthEndpoints _endpoints;

    internal PostaAuthClient(PostaTransport transport, IPostaAuthEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
