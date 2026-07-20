using Posta.Models.Constants;

namespace Posta.Tests;

public sealed class ConstantsTests
{
    [Theory]
    [InlineData(EmailVerificationStatuses.Valid, "valid")]
    [InlineData(EmailVerificationStatuses.Invalid, "invalid")]
    [InlineData(EmailVerificationStatuses.Risky, "risky")]
    [InlineData(EmailVerificationStatuses.Disposable, "disposable")]
    [InlineData(EmailVerificationStatuses.Unknown, "unknown")]
    [InlineData(UserRoles.Admin, "admin")]
    [InlineData(UserRoles.User, "user")]
    [InlineData(WebhookEvents.EmailSent, "email.sent")]
    [InlineData(WebhookEvents.EmailFailed, "email.failed")]
    [InlineData(WebhookEvents.EmailInbound, "email.inbound")]
    [InlineData(WebhookEvents.EmailUnsubscribed, "email.unsubscribed")]
    [InlineData(WebhookEvents.EmailComplained, "email.complained")]
    [InlineData(WebhookEvents.CampaignStarted, "campaign.started")]
    [InlineData(WebhookEvents.CampaignCompleted, "campaign.completed")]
    [InlineData(SmtpSecurityModes.Permissive, "permissive")]
    [InlineData(SmtpSecurityModes.Strict, "strict")]
    [InlineData(ApiKeyScopes.Send, "send")]
    [InlineData(ApiKeyScopes.Read, "read")]
    [InlineData(ApiKeyScopes.Webhooks, "webhooks")]
    [InlineData(ApiKeyScopes.All, "*")]
    [InlineData(BounceTypes.Hard, "hard")]
    [InlineData(BounceTypes.Soft, "soft")]
    public void ConstantMatchesWireValue(string constant, string expected)
    {
        Assert.Equal(expected, constant);
    }
}
