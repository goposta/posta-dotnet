namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Campaigns API area.</summary>
public interface IPostaCampaignsEndpoints
{
    /// <summary>List campaigns</summary>
        PostaEndpoint ListCampaigns { get; }

    /// <summary>Create campaign</summary>
        PostaEndpoint CreateCampaign { get; }

    /// <summary>Delete campaign</summary>
        PostaEndpoint DeleteCampaign { get; }

    /// <summary>Get campaign</summary>
        PostaEndpoint GetCampaign { get; }

    /// <summary>Update campaign</summary>
        PostaEndpoint UpdateCampaign { get; }

    /// <summary>Get campaign analytics</summary>
        PostaEndpoint GetCampaignAnalytics { get; }

    /// <summary>Cancel campaign</summary>
        PostaEndpoint CancelCampaign { get; }

    /// <summary>Duplicate campaign</summary>
        PostaEndpoint DuplicateCampaign { get; }

    /// <summary>List campaign messages</summary>
        PostaEndpoint ListCampaignMessages { get; }

    /// <summary>Pause campaign</summary>
        PostaEndpoint PauseCampaign { get; }

    /// <summary>Resume campaign</summary>
        PostaEndpoint ResumeCampaign { get; }

    /// <summary>Send campaign</summary>
        PostaEndpoint SendCampaign { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint ListCampaigns { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/campaigns", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CreateCampaign { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/campaigns", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DeleteCampaign { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/campaigns/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetCampaign { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/campaigns/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint UpdateCampaign { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/campaigns/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint GetCampaignAnalytics { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/campaigns/{id}/analytics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint CancelCampaign { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/campaigns/{id}/cancel", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint DuplicateCampaign { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/campaigns/{id}/duplicate", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ListCampaignMessages { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/campaigns/{id}/messages", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint PauseCampaign { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/campaigns/{id}/pause", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint ResumeCampaign { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/campaigns/{id}/resume", PostaAuthentication.AccessToken);

    /// <inheritdoc />
        public virtual PostaEndpoint SendCampaign { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/campaigns/{id}/send", PostaAuthentication.AccessToken);
}
