using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the Workspaces API area.</summary>
public sealed partial class PostaWorkspacesClient : PostaSectionClient
{
    private readonly IPostaWorkspacesEndpoints _endpoints;

    internal PostaWorkspacesClient(PostaTransport transport, IPostaWorkspacesEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
