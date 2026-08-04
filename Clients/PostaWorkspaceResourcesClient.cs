using Posta.Endpoints;
using Posta.Transport;

namespace Posta.Clients;

/// <summary>Provides operations for the WorkspaceResources API area.</summary>
public sealed partial class PostaWorkspaceResourcesClient : PostaSectionClient
{
    private readonly IPostaWorkspaceResourcesEndpoints _endpoints;

    internal PostaWorkspaceResourcesClient(PostaTransport transport, IPostaWorkspaceResourcesEndpoints endpoints)
        : base(transport)
    {
        _endpoints = endpoints;
    }
}
