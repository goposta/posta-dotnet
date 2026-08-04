using Posta.Endpoints;
using Posta.Configuration;
using Posta.Transport;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Posta.Clients;

/// <summary>Client for the Posta HTTP API.</summary>
public sealed class PostaClient : IDisposable
{
    private readonly HttpClient? _ownedHttpClient;

    /// <summary>Creates a client for a Posta server.</summary>
    /// <param name="baseUrl">The base URL of the Posta server.</param>
    /// <param name="apiKey">The Posta API key.</param>
    public PostaClient(string baseUrl, string apiKey)
        : this(baseUrl, apiKey, NullLoggerFactory.Instance)
    {
    }

    /// <summary>Creates a client for a Posta server with SDK logging.</summary>
    /// <param name="baseUrl">The base URL of the Posta server.</param>
    /// <param name="apiKey">The Posta API key.</param>
    /// <param name="loggerFactory">The logger factory used for SDK logs.</param>
    public PostaClient(string baseUrl, string apiKey, ILoggerFactory loggerFactory)
        : this(new PostaClientSettings
        {
            Endpoint = new Uri(baseUrl, UriKind.Absolute),
            ApiKey = apiKey
        }, loggerFactory)
    {
    }

    /// <summary>Creates a client using the supplied settings.</summary>
    public PostaClient(PostaClientSettings settings)
        : this(settings, NullLoggerFactory.Instance)
    {
    }

    /// <summary>Creates a client using the supplied settings and logger factory.</summary>
    public PostaClient(PostaClientSettings settings, ILoggerFactory loggerFactory)
    {
        ArgumentNullException.ThrowIfNull(settings);
        ArgumentNullException.ThrowIfNull(loggerFactory);
        if (settings.Endpoint is null)
        {
            throw new ArgumentException("A Posta endpoint is required.", nameof(settings));
        }

        _ownedHttpClient = new HttpClient
        {
            BaseAddress = settings.Endpoint,
            Timeout = settings.Timeout
        };

        Endpoints = new PostaEndpoints();
        InitializeClients(new PostaTransport(
            _ownedHttpClient,
            new PostaCredentialProvider(settings),
            loggerFactory.CreateLogger("Posta.Transport")));
    }

    /// <summary>
    /// Creates a client over an externally managed <see cref="HttpClient"/>.
    /// </summary>
    /// <remarks>The supplied HTTP client is not disposed by this instance.</remarks>
    public PostaClient(
        HttpClient httpClient,
        IPostaCredentialProvider credentialProvider,
        IPostaEndpoints? endpoints = null)
        : this(httpClient, credentialProvider, endpoints, NullLoggerFactory.Instance)
    {
    }

    /// <summary>
    /// Creates a client over an externally managed <see cref="HttpClient"/> with SDK logging.
    /// </summary>
    /// <remarks>The supplied HTTP client is not disposed by this instance.</remarks>
    public PostaClient(
        HttpClient httpClient,
        IPostaCredentialProvider credentialProvider,
        IPostaEndpoints? endpoints,
        ILoggerFactory loggerFactory)
    {
        ArgumentNullException.ThrowIfNull(httpClient);
        ArgumentNullException.ThrowIfNull(credentialProvider);
        ArgumentNullException.ThrowIfNull(loggerFactory);
        if (httpClient.BaseAddress is null)
        {
            throw new ArgumentException("The HTTP client must have a base address.", nameof(httpClient));
        }

        Endpoints = endpoints ?? new PostaEndpoints();
        InitializeClients(new PostaTransport(
            httpClient,
            credentialProvider,
            loggerFactory.CreateLogger("Posta.Transport")));
    }

    /// <summary>Gets the endpoint catalog.</summary>
    public IPostaEndpoints Endpoints { get; }

    public PostaAuthClient Auth { get; private set; } = null!;
    public PostaOAuthClient OAuth { get; private set; } = null!;
    public PostaUsersClient Users { get; private set; } = null!;
    public PostaWorkspacesClient Workspaces { get; private set; } = null!;
    public PostaEmailsClient Emails { get; private set; } = null!;
    public PostaTemplatesClient Templates { get; private set; } = null!;
    public PostaCampaignsClient Campaigns { get; private set; } = null!;
    public PostaSubscribersClient Subscribers { get; private set; } = null!;
    public PostaSubscriberListsClient SubscriberLists { get; private set; } = null!;
    public PostaUnsubscribeListsClient UnsubscribeLists { get; private set; } = null!;
    public PostaWebhooksClient Webhooks { get; private set; } = null!;
    public PostaWorkspaceResourcesClient WorkspaceResources { get; private set; } = null!;
    public PostaAdminClient Admin { get; private set; } = null!;
    public PostaHealthClient Health { get; private set; } = null!;
    public PostaInfoClient Info { get; private set; } = null!;

    private void InitializeClients(PostaTransport transport)
    {
        Auth = new PostaAuthClient(transport, Endpoints);
        OAuth = new PostaOAuthClient(transport, Endpoints);
        Users = new PostaUsersClient(transport, Endpoints);
        Workspaces = new PostaWorkspacesClient(transport, Endpoints);
        Emails = new PostaEmailsClient(transport, Endpoints);
        Templates = new PostaTemplatesClient(transport, Endpoints);
        Campaigns = new PostaCampaignsClient(transport, Endpoints);
        Subscribers = new PostaSubscribersClient(transport, Endpoints);
        SubscriberLists = new PostaSubscriberListsClient(transport, Endpoints);
        UnsubscribeLists = new PostaUnsubscribeListsClient(transport, Endpoints);
        Webhooks = new PostaWebhooksClient(transport, Endpoints);
        WorkspaceResources = new PostaWorkspaceResourcesClient(transport, Endpoints);
        Admin = new PostaAdminClient(transport, Endpoints);
        Health = new PostaHealthClient(transport, Endpoints);
        Info = new PostaInfoClient(transport, Endpoints);
    }

    /// <summary>Releases the internally owned HTTP client, if one was created.</summary>
    public void Dispose() => _ownedHttpClient?.Dispose();
}
