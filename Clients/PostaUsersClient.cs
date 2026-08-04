using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Users API area.</summary>
public sealed partial class PostaUsersClient : PostaSectionClient
{
    private readonly IPostaUsersEndpoints _endpoints;

    internal PostaUsersClient(PostaTransport transport, IPostaUsersEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
