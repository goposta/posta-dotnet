using Posta.Endpoints;

namespace Posta.Clients;

/// <summary>
/// Provides access to all Posta API sections and endpoint definitions.
/// </summary>
public interface IPostaClient
{
    /// <summary>Gets the overridable endpoint catalog.</summary>
    IPostaEndpoints Endpoints { get; }
    /// <summary>Gets authentication operations.</summary>
    IPostaAuthClient Auth { get; }
    /// <summary>Gets OAuth operations.</summary>
    IPostaOAuthClient OAuth { get; }
    /// <summary>Gets current-user operations.</summary>
    IPostaUsersClient Users { get; }
    /// <summary>Gets workspace operations.</summary>
    IPostaWorkspacesClient Workspaces { get; }
    /// <summary>Gets email operations.</summary>
    IPostaEmailsClient Emails { get; }
    /// <summary>Gets template operations.</summary>
    IPostaTemplatesClient Templates { get; }
    /// <summary>Gets campaign operations.</summary>
    IPostaCampaignsClient Campaigns { get; }
    /// <summary>Gets subscriber operations.</summary>
    IPostaSubscribersClient Subscribers { get; }
    /// <summary>Gets subscriber-list operations.</summary>
    IPostaSubscriberListsClient SubscriberLists { get; }
    /// <summary>Gets unsubscribe-list operations.</summary>
    IPostaUnsubscribeListsClient UnsubscribeLists { get; }
    /// <summary>Gets inbound email operations.</summary>
    IPostaInboundClient Inbound { get; }
    /// <summary>Gets webhook operations.</summary>
    IPostaWebhooksClient Webhooks { get; }
    /// <summary>Gets other workspace-scoped resource operations.</summary>
    IPostaWorkspaceResourcesClient WorkspaceResources { get; }
    /// <summary>Gets administrator operations.</summary>
    IPostaAdminClient Admin { get; }
    /// <summary>Gets health operations.</summary>
    IPostaHealthClient Health { get; }
    /// <summary>Gets server information operations.</summary>
    IPostaInfoClient Info { get; }
}