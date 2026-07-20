using Posta.Endpoints;
using Posta.Configuration;
using Posta.Transport;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;

namespace Posta.Clients;

/// <summary>Client for the Posta HTTP API.</summary>
public sealed class PostaClient : IPostaClient, IDisposable
{
    private readonly PostaClientSection _section;
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
        _section = new PostaClientSection(
            new PostaTransport(_ownedHttpClient, new PostaCredentialProvider(settings), loggerFactory.CreateLogger("Posta.Transport")),
            Endpoints);
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
        _section = new PostaClientSection(
            new PostaTransport(httpClient, credentialProvider, loggerFactory.CreateLogger("Posta.Transport")),
            Endpoints);
    }

    /// <inheritdoc />
    public IPostaEndpoints Endpoints { get; }
    /// <inheritdoc />
    public IPostaAuthClient Auth => _section;
    /// <inheritdoc />
    public IPostaOAuthClient OAuth => _section;
    /// <inheritdoc />
    public IPostaUsersClient Users => _section;
    /// <inheritdoc />
    public IPostaWorkspacesClient Workspaces => _section;
    /// <inheritdoc />
    public IPostaEmailsClient Emails => _section;
    /// <inheritdoc />
    public IPostaTemplatesClient Templates => _section;
    /// <inheritdoc />
    public IPostaCampaignsClient Campaigns => _section;
    /// <inheritdoc />
    public IPostaSubscribersClient Subscribers => _section;
    /// <inheritdoc />
    public IPostaSubscriberListsClient SubscriberLists => _section;
    /// <inheritdoc />
    public IPostaUnsubscribeListsClient UnsubscribeLists => _section;
    /// <inheritdoc />
    public IPostaInboundClient Inbound => _section;
    /// <inheritdoc />
    public IPostaWebhooksClient Webhooks => _section;
    /// <inheritdoc />
    public IPostaWorkspaceResourcesClient WorkspaceResources => _section;
    /// <inheritdoc />
    public IPostaAdminClient Admin => _section;
    /// <inheritdoc />
    public IPostaHealthClient Health => _section;
    /// <inheritdoc />
    public IPostaInfoClient Info => _section;

    /// <summary>Releases the internally owned HTTP client, if one was created.</summary>
    public void Dispose() => _ownedHttpClient?.Dispose();
}
