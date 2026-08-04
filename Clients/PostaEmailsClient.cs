using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Emails API area.</summary>
public sealed partial class PostaEmailsClient : PostaSectionClient
{
    private readonly IPostaEmailsEndpoints _endpoints;

    internal PostaEmailsClient(PostaTransport transport, IPostaEmailsEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
