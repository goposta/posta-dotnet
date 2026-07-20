namespace Posta.Models.Constants;

/// <summary>Provides the supported webhook event names.</summary>
public static class WebhookEvents
{
    /// <summary>An email was sent.</summary>
    public const string EmailSent = "email.sent";

    /// <summary>An email failed to send.</summary>
    public const string EmailFailed = "email.failed";

    /// <summary>An inbound email was received.</summary>
    public const string EmailInbound = "email.inbound";

    /// <summary>A recipient unsubscribed.</summary>
    public const string EmailUnsubscribed = "email.unsubscribed";

    /// <summary>A recipient submitted a complaint.</summary>
    public const string EmailComplained = "email.complained";

    /// <summary>A campaign started.</summary>
    public const string CampaignStarted = "campaign.started";

    /// <summary>A campaign completed.</summary>
    public const string CampaignCompleted = "campaign.completed";
}
