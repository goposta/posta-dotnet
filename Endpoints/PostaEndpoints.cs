namespace Posta.Endpoints;

/// <summary>Provides overridable definitions for every supported Posta API endpoint.</summary>
/// <summary>Aggregate catalog containing every Posta API endpoint.</summary>
public interface IPostaEndpoints :
    IPostaAdminEndpoints,
    IPostaAuthEndpoints,
    IPostaCampaignsEndpoints,
    IPostaEmailsEndpoints,
    IPostaHealthEndpoints,
    IPostaInboundEndpoints,
    IPostaInfoEndpoints,
    IPostaOAuthEndpoints,
    IPostaSubscriberListsEndpoints,
    IPostaSubscribersEndpoints,
    IPostaTemplatesEndpoints,
    IPostaUnsubscribeListsEndpoints,
    IPostaUsersEndpoints,
    IPostaWebhooksEndpoints,
    IPostaWorkspaceResourcesEndpoints,
    IPostaWorkspacesEndpoints
{
}

/// <summary>Default, overridable Posta 0.13.1 endpoint definitions.</summary>
public partial class PostaEndpoints : IPostaEndpoints
{
}
