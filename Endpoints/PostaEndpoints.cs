namespace Posta.Endpoints;

/// <summary>Provides overridable definitions for every supported Posta API endpoint.</summary>
public interface IPostaEndpoints
{
    /// <summary>Platform analytics</summary>
    PostaEndpoint PlatformAnalytics { get; }

    /// <summary>Platform dashboard analytics</summary>
    PostaEndpoint PlatformDashboardAnalytics { get; }

    /// <summary>Platform deliverability by provider</summary>
    PostaEndpoint PlatformDeliverabilityByProvider { get; }

    /// <summary>List events</summary>
    PostaEndpoint ListEvents { get; }

    /// <summary>Get event</summary>
    PostaEndpoint GetEvent { get; }

    /// <summary>List scheduled jobs</summary>
    PostaEndpoint ListScheduledJobs { get; }

    /// <summary>Platform metrics</summary>
    PostaEndpoint PlatformMetrics { get; }

    /// <summary>List all OAuth providers (admin)</summary>
    PostaEndpoint ListAllOauthProvidersAdmin { get; }

    /// <summary>Create OAuth provider</summary>
    PostaEndpoint CreateOauthProvider { get; }

    /// <summary>Delete OAuth provider</summary>
    PostaEndpoint DeleteOauthProvider { get; }

    /// <summary>Update OAuth provider</summary>
    PostaEndpoint UpdateOauthProvider { get; }

    /// <summary>List plans</summary>
    PostaEndpoint ListPlans { get; }

    /// <summary>Create plan</summary>
    PostaEndpoint CreatePlan { get; }

    /// <summary>Delete plan</summary>
    PostaEndpoint DeletePlan { get; }

    /// <summary>Get plan</summary>
    PostaEndpoint GetPlan { get; }

    /// <summary>Update plan</summary>
    PostaEndpoint UpdatePlan { get; }

    /// <summary>Set plan as default</summary>
    PostaEndpoint SetPlanAsDefault { get; }

    /// <summary>List shared SMTP servers</summary>
    PostaEndpoint ListSharedSmtpServers { get; }

    /// <summary>Create shared SMTP server</summary>
    PostaEndpoint CreateSharedSmtpServer { get; }

    /// <summary>Delete shared SMTP server</summary>
    PostaEndpoint DeleteSharedSmtpServer { get; }

    /// <summary>Get shared SMTP server</summary>
    PostaEndpoint GetSharedSmtpServer { get; }

    /// <summary>Update shared SMTP server</summary>
    PostaEndpoint UpdateSharedSmtpServer { get; }

    /// <summary>Disable shared SMTP server</summary>
    PostaEndpoint DisableSharedSmtpServer { get; }

    /// <summary>Enable shared SMTP server</summary>
    PostaEndpoint EnableSharedSmtpServer { get; }

    /// <summary>Test shared SMTP server connection</summary>
    PostaEndpoint TestSharedSmtpServerConnection { get; }

    /// <summary>Get platform settings</summary>
    PostaEndpoint GetPlatformSettings { get; }

    /// <summary>Update platform settings</summary>
    PostaEndpoint UpdatePlatformSettings { get; }

    /// <summary>Get update status</summary>
    PostaEndpoint GetUpdateStatus { get; }

    /// <summary>Dismiss an update notice</summary>
    PostaEndpoint DismissUpdateNotice { get; }

    /// <summary>List all users</summary>
    PostaEndpoint ListAllUsers { get; }

    /// <summary>Create a new user</summary>
    PostaEndpoint CreateANewUser { get; }

    /// <summary>Delete user</summary>
    PostaEndpoint DeleteUser { get; }

    /// <summary>Update user</summary>
    PostaEndpoint UpdateUser { get; }

    /// <summary>Disable 2FA for user</summary>
    PostaEndpoint Disable2faForUser { get; }

    /// <summary>Cancel user deletion</summary>
    PostaEndpoint CancelUserDeletion { get; }

    /// <summary>Force delete user</summary>
    PostaEndpoint ForceDeleteUser { get; }

    /// <summary>Get user metrics</summary>
    PostaEndpoint GetUserMetrics { get; }

    /// <summary>Get user plan</summary>
    PostaEndpoint GetUserPlan { get; }

    /// <summary>Assign plan to user</summary>
    PostaEndpoint AssignPlanToUser { get; }

    /// <summary>Revoke all user sessions</summary>
    PostaEndpoint RevokeAllUserSessions { get; }

    /// <summary>List user workspaces</summary>
    PostaEndpoint ListUserWorkspaces { get; }

    /// <summary>Get workspace plan</summary>
    PostaEndpoint GetWorkspacePlan { get; }

    /// <summary>Assign plan to workspace</summary>
    PostaEndpoint AssignPlanToWorkspace { get; }

    /// <summary>Request password reset</summary>
    PostaEndpoint RequestPasswordReset { get; }

    /// <summary>Login</summary>
    PostaEndpoint Login { get; }

    /// <summary>Discover SSO provider by email</summary>
    PostaEndpoint DiscoverSsoProviderByEmail { get; }

    /// <summary>List OAuth providers</summary>
    PostaEndpoint ListOauthProviders { get; }

    /// <summary>Initiate OAuth flow</summary>
    PostaEndpoint InitiateOauthFlow { get; }

    /// <summary>Register</summary>
    PostaEndpoint Register { get; }

    /// <summary>Registration status</summary>
    PostaEndpoint RegistrationStatus { get; }

    /// <summary>Reset password</summary>
    PostaEndpoint ResetPassword { get; }

    /// <summary>Verify email address</summary>
    PostaEndpoint VerifyEmailAddress { get; }

    /// <summary>List bounces</summary>
    PostaEndpoint ListBounces { get; }

    /// <summary>List emails</summary>
    PostaEndpoint ListEmails { get; }

    /// <summary>Send batch emails</summary>
    PostaEndpoint SendBatchEmails { get; }

    /// <summary>Preview email from template</summary>
    PostaEndpoint PreviewEmailFromTemplate { get; }

    /// <summary>Send an email</summary>
    PostaEndpoint SendAnEmail { get; }

    /// <summary>Send email using template</summary>
    PostaEndpoint SendEmailUsingTemplate { get; }

    /// <summary>Verify an email address</summary>
    PostaEndpoint VerifyAnEmailAddress { get; }

    /// <summary>Get email details</summary>
    PostaEndpoint GetEmailDetails { get; }

    /// <summary>Retry failed email</summary>
    PostaEndpoint RetryFailedEmail { get; }

    /// <summary>Get email delivery status</summary>
    PostaEndpoint GetEmailDeliveryStatus { get; }

    /// <summary>Receive inbound email via webhook</summary>
    PostaEndpoint ReceiveInboundEmailViaWebhook { get; }

    /// <summary>Application info</summary>
    PostaEndpoint ApplicationInfo { get; }

    /// <summary>My pending invitations</summary>
    PostaEndpoint MyPendingInvitations { get; }

    /// <summary>Accept invitation</summary>
    PostaEndpoint AcceptInvitation { get; }

    /// <summary>Decline invitation by token</summary>
    PostaEndpoint DeclineInvitationByToken { get; }

    /// <summary>Accept invitation by ID</summary>
    PostaEndpoint AcceptInvitationById { get; }

    /// <summary>Decline invitation by ID</summary>
    PostaEndpoint DeclineInvitationById { get; }

    /// <summary>Subscribe an email to a list</summary>
    PostaEndpoint SubscribeAnEmailToAList { get; }

    /// <summary>Re-subscribe an email to a list</summary>
    PostaEndpoint ReSubscribeAnEmailToAList { get; }

    /// <summary>Unsubscribe an email from a list</summary>
    PostaEndpoint UnsubscribeAnEmailFromAList { get; }

    /// <summary>Get current user profile</summary>
    PostaEndpoint GetCurrentUserProfile { get; }

    /// <summary>Update profile</summary>
    PostaEndpoint UpdateProfile { get; }

    /// <summary>Disable 2FA</summary>
    PostaEndpoint Disable2fa { get; }

    /// <summary>Setup 2FA</summary>
    PostaEndpoint Setup2fa { get; }

    /// <summary>Verify and enable 2FA</summary>
    PostaEndpoint VerifyAndEnable2fa { get; }

    /// <summary>List user audit log</summary>
    PostaEndpoint ListUserAuditLog { get; }

    /// <summary>Cancel account deletion</summary>
    PostaEndpoint CancelAccountDeletion { get; }

    /// <summary>Request account deletion</summary>
    PostaEndpoint RequestAccountDeletion { get; }

    /// <summary>List linked OAuth accounts</summary>
    PostaEndpoint ListLinkedOauthAccounts { get; }

    /// <summary>Unlink OAuth account</summary>
    PostaEndpoint UnlinkOauthAccount { get; }

    /// <summary>Change password</summary>
    PostaEndpoint ChangePassword { get; }

    /// <summary>Get my plan</summary>
    PostaEndpoint GetMyPlan { get; }

    /// <summary>List active sessions</summary>
    PostaEndpoint ListActiveSessions { get; }

    /// <summary>Logout current session</summary>
    PostaEndpoint LogoutCurrentSession { get; }

    /// <summary>Revoke all other sessions</summary>
    PostaEndpoint RevokeAllOtherSessions { get; }

    /// <summary>Revoke session</summary>
    PostaEndpoint RevokeSession { get; }

    /// <summary>Get user settings</summary>
    PostaEndpoint GetUserSettings { get; }

    /// <summary>Update user settings</summary>
    PostaEndpoint UpdateUserSettings { get; }

    /// <summary>Resend verification email</summary>
    PostaEndpoint ResendVerificationEmail { get; }

    /// <summary>List webhook deliveries</summary>
    PostaEndpoint ListWebhookDeliveries { get; }

    /// <summary>List webhooks</summary>
    PostaEndpoint ListWebhooks { get; }

    /// <summary>Create webhook</summary>
    PostaEndpoint CreateWebhook { get; }

    /// <summary>Bounce notification webhook</summary>
    PostaEndpoint BounceNotificationWebhook { get; }

    /// <summary>Delete webhook</summary>
    PostaEndpoint DeleteWebhook { get; }

    /// <summary>List workspaces</summary>
    PostaEndpoint ListWorkspaces { get; }

    /// <summary>Create workspace</summary>
    PostaEndpoint CreateWorkspace { get; }

    /// <summary>Delete workspace</summary>
    PostaEndpoint DeleteWorkspace { get; }

    /// <summary>Get current workspace</summary>
    PostaEndpoint GetCurrentWorkspace { get; }

    /// <summary>Update workspace</summary>
    PostaEndpoint UpdateWorkspace { get; }

    /// <summary>Email analytics</summary>
    PostaEndpoint EmailAnalytics { get; }

    /// <summary>Dashboard analytics</summary>
    PostaEndpoint DashboardAnalytics { get; }

    /// <summary>Deliverability by provider</summary>
    PostaEndpoint DeliverabilityByProvider { get; }

    /// <summary>List API keys</summary>
    PostaEndpoint ListApiKeys { get; }

    /// <summary>Create API key</summary>
    PostaEndpoint CreateApiKey { get; }

    /// <summary>Delete API key</summary>
    PostaEndpoint DeleteApiKey { get; }

    /// <summary>Get API key</summary>
    PostaEndpoint GetApiKey { get; }

    /// <summary>Revoke API key</summary>
    PostaEndpoint RevokeApiKey { get; }

    /// <summary>List workspace audit log</summary>
    PostaEndpoint ListWorkspaceAuditLog { get; }

    /// <summary>Get workspace audit event</summary>
    PostaEndpoint GetWorkspaceAuditEvent { get; }

    /// <summary>List bounces</summary>
    PostaEndpoint ListBouncesWorkspaceResources { get; }

    /// <summary>Record a bounce</summary>
    PostaEndpoint RecordABounce { get; }

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

    /// <summary>List contacts</summary>
    PostaEndpoint ListContacts { get; }

    /// <summary>Get contact details</summary>
    PostaEndpoint GetContactDetails { get; }

    /// <summary>Get dashboard statistics</summary>
    PostaEndpoint GetDashboardStatistics { get; }

    /// <summary>Export workspace data</summary>
    PostaEndpoint ExportWorkspaceData { get; }

    /// <summary>Import workspace data</summary>
    PostaEndpoint ImportWorkspaceData { get; }

    /// <summary>List domains</summary>
    PostaEndpoint ListDomains { get; }

    /// <summary>Add domain</summary>
    PostaEndpoint AddDomain { get; }

    /// <summary>Delete domain</summary>
    PostaEndpoint DeleteDomain { get; }

    /// <summary>Get domain details</summary>
    PostaEndpoint GetDomainDetails { get; }

    /// <summary>Verify domain DNS records</summary>
    PostaEndpoint VerifyDomainDnsRecords { get; }

    /// <summary>List emails</summary>
    PostaEndpoint ListEmailsWorkspaceResources { get; }

    /// <summary>Preview email from template</summary>
    PostaEndpoint PreviewEmailFromTemplateWorkspaceResources { get; }

    /// <summary>Get email details</summary>
    PostaEndpoint GetEmailDetailsWorkspaceResources { get; }

    /// <summary>Retry failed email</summary>
    PostaEndpoint RetryFailedEmailWorkspaceResources { get; }

    /// <summary>Get email delivery status</summary>
    PostaEndpoint GetEmailDeliveryStatusWorkspaceResources { get; }

    /// <summary>Delete workspace contact data (GDPR)</summary>
    PostaEndpoint DeleteWorkspaceContactDataGdpr { get; }

    /// <summary>Delete workspace email logs (GDPR)</summary>
    PostaEndpoint DeleteWorkspaceEmailLogsGdpr { get; }

    /// <summary>List inbound emails</summary>
    PostaEndpoint ListInboundEmails { get; }

    /// <summary>Delete an inbound email</summary>
    PostaEndpoint DeleteAnInboundEmail { get; }

    /// <summary>Get an inbound email by UUID</summary>
    PostaEndpoint GetAnInboundEmailByUuid { get; }

    /// <summary>Download the raw RFC 5322 message (.eml)</summary>
    PostaEndpoint DownloadTheRawRfc5322MessageEml { get; }

    /// <summary>Retry webhook dispatch for a failed inbound email</summary>
    PostaEndpoint RetryWebhookDispatchForAFailedInboundEmail { get; }

    /// <summary>Download an inbound email attachment (authenticated)</summary>
    PostaEndpoint DownloadAnInboundEmailAttachmentAuthenticated { get; }

    /// <summary>List pending invitations</summary>
    PostaEndpoint ListPendingInvitations { get; }

    /// <summary>Invite member</summary>
    PostaEndpoint InviteMember { get; }

    /// <summary>Cancel invitation</summary>
    PostaEndpoint CancelInvitation { get; }

    /// <summary>List languages</summary>
    PostaEndpoint ListLanguages { get; }

    /// <summary>Create language</summary>
    PostaEndpoint CreateLanguage { get; }

    /// <summary>Delete language</summary>
    PostaEndpoint DeleteLanguage { get; }

    /// <summary>Update language</summary>
    PostaEndpoint UpdateLanguage { get; }

    /// <summary>Delete localization</summary>
    PostaEndpoint DeleteLocalization { get; }

    /// <summary>Update localization</summary>
    PostaEndpoint UpdateLocalization { get; }

    /// <summary>List workspace members</summary>
    PostaEndpoint ListWorkspaceMembers { get; }

    /// <summary>Remove member</summary>
    PostaEndpoint RemoveMember { get; }

    /// <summary>Update member role</summary>
    PostaEndpoint UpdateMemberRole { get; }

    /// <summary>Get workspace plan</summary>
    PostaEndpoint GetWorkspacePlanWorkspaces { get; }

    /// <summary>Get workspace settings</summary>
    PostaEndpoint GetWorkspaceSettings { get; }

    /// <summary>Update workspace settings</summary>
    PostaEndpoint UpdateWorkspaceSettings { get; }

    /// <summary>List SMTP servers</summary>
    PostaEndpoint ListSmtpServers { get; }

    /// <summary>Add SMTP server</summary>
    PostaEndpoint AddSmtpServer { get; }

    /// <summary>Delete SMTP server</summary>
    PostaEndpoint DeleteSmtpServer { get; }

    /// <summary>Get SMTP server</summary>
    PostaEndpoint GetSmtpServer { get; }

    /// <summary>Update SMTP server</summary>
    PostaEndpoint UpdateSmtpServer { get; }

    /// <summary>Test SMTP server connection</summary>
    PostaEndpoint TestSmtpServerConnection { get; }

    /// <summary>Delete workspace SSO config</summary>
    PostaEndpoint DeleteWorkspaceSsoConfig { get; }

    /// <summary>Get workspace SSO config</summary>
    PostaEndpoint GetWorkspaceSsoConfig { get; }

    /// <summary>Set workspace SSO config</summary>
    PostaEndpoint SetWorkspaceSsoConfig { get; }

    /// <summary>List stylesheets</summary>
    PostaEndpoint ListStylesheets { get; }

    /// <summary>Create stylesheet</summary>
    PostaEndpoint CreateStylesheet { get; }

    /// <summary>Delete stylesheet</summary>
    PostaEndpoint DeleteStylesheet { get; }

    /// <summary>Update stylesheet</summary>
    PostaEndpoint UpdateStylesheet { get; }

    /// <summary>List subscriber lists</summary>
    PostaEndpoint ListSubscriberLists { get; }

    /// <summary>Create subscriber list</summary>
    PostaEndpoint CreateSubscriberList { get; }

    /// <summary>Preview segment count</summary>
    PostaEndpoint PreviewSegmentCount { get; }

    /// <summary>Delete subscriber list</summary>
    PostaEndpoint DeleteSubscriberList { get; }

    /// <summary>Get subscriber list</summary>
    PostaEndpoint GetSubscriberList { get; }

    /// <summary>Update subscriber list</summary>
    PostaEndpoint UpdateSubscriberList { get; }

    /// <summary>Remove subscriber from list</summary>
    PostaEndpoint RemoveSubscriberFromList { get; }

    /// <summary>List members of subscriber list</summary>
    PostaEndpoint ListMembersOfSubscriberList { get; }

    /// <summary>Add subscriber to list</summary>
    PostaEndpoint AddSubscriberToList { get; }

    /// <summary>Re-subscribe an email to a list</summary>
    PostaEndpoint ReSubscribeAnEmailToAListSubscriberLists { get; }

    /// <summary>Unsubscribe an email from a list</summary>
    PostaEndpoint UnsubscribeAnEmailFromAListSubscriberLists { get; }

    /// <summary>List subscribers</summary>
    PostaEndpoint ListSubscribers { get; }

    /// <summary>Create subscriber</summary>
    PostaEndpoint CreateSubscriber { get; }

    /// <summary>Bulk import subscribers (CSV)</summary>
    PostaEndpoint BulkImportSubscribersCsv { get; }

    /// <summary>Bulk import subscribers (JSON)</summary>
    PostaEndpoint BulkImportSubscribersJson { get; }

    /// <summary>Delete subscriber</summary>
    PostaEndpoint DeleteSubscriber { get; }

    /// <summary>Get subscriber</summary>
    PostaEndpoint GetSubscriber { get; }

    /// <summary>Update subscriber</summary>
    PostaEndpoint UpdateSubscriber { get; }

    /// <summary>Remove from suppression list</summary>
    PostaEndpoint RemoveFromSuppressionList { get; }

    /// <summary>List suppressed emails</summary>
    PostaEndpoint ListSuppressedEmails { get; }

    /// <summary>Add to suppression list</summary>
    PostaEndpoint AddToSuppressionList { get; }

    /// <summary>List templates</summary>
    PostaEndpoint ListTemplates { get; }

    /// <summary>Create template</summary>
    PostaEndpoint CreateTemplate { get; }

    /// <summary>Import template</summary>
    PostaEndpoint ImportTemplate { get; }

    /// <summary>Import HTML template</summary>
    PostaEndpoint ImportHtmlTemplate { get; }

    /// <summary>Preview template</summary>
    PostaEndpoint PreviewTemplate { get; }

    /// <summary>Delete template</summary>
    PostaEndpoint DeleteTemplate { get; }

    /// <summary>Get template</summary>
    PostaEndpoint GetTemplate { get; }

    /// <summary>Update template</summary>
    PostaEndpoint UpdateTemplate { get; }

    /// <summary>Activate template version</summary>
    PostaEndpoint ActivateTemplateVersion { get; }

    /// <summary>Export template</summary>
    PostaEndpoint ExportTemplate { get; }

    /// <summary>Send test email</summary>
    PostaEndpoint SendTestEmail { get; }

    /// <summary>List template versions</summary>
    PostaEndpoint ListTemplateVersions { get; }

    /// <summary>Create template version</summary>
    PostaEndpoint CreateTemplateVersion { get; }

    /// <summary>Delete template version</summary>
    PostaEndpoint DeleteTemplateVersion { get; }

    /// <summary>Update template version</summary>
    PostaEndpoint UpdateTemplateVersion { get; }

    /// <summary>List localizations for a version</summary>
    PostaEndpoint ListLocalizationsForAVersion { get; }

    /// <summary>Create localization</summary>
    PostaEndpoint CreateLocalization { get; }

    /// <summary>Preview localized template</summary>
    PostaEndpoint PreviewLocalizedTemplate { get; }

    /// <summary>List unsubscribe lists</summary>
    PostaEndpoint ListUnsubscribeLists { get; }

    /// <summary>Create unsubscribe list</summary>
    PostaEndpoint CreateUnsubscribeList { get; }

    /// <summary>Delete unsubscribe list</summary>
    PostaEndpoint DeleteUnsubscribeList { get; }

    /// <summary>Get unsubscribe list</summary>
    PostaEndpoint GetUnsubscribeList { get; }

    /// <summary>Update unsubscribe list</summary>
    PostaEndpoint UpdateUnsubscribeList { get; }

    /// <summary>List webhook deliveries</summary>
    PostaEndpoint ListWebhookDeliveriesWorkspaceResources { get; }

    /// <summary>List webhooks</summary>
    PostaEndpoint ListWebhooksWorkspaceResources { get; }

    /// <summary>Create webhook</summary>
    PostaEndpoint CreateWebhookUser { get; }

    /// <summary>Delete webhook</summary>
    PostaEndpoint DeleteWebhookUser { get; }

    /// <summary>Liveness probe</summary>
    PostaEndpoint LivenessProbe { get; }

    /// <summary>Readiness probe</summary>
    PostaEndpoint ReadinessProbe { get; }

}

/// <summary>Default, overridable Posta 0.11.0 endpoint definitions.</summary>
public class PostaEndpoints : IPostaEndpoints
{
    /// <inheritdoc />
    public virtual PostaEndpoint PlatformAnalytics { get; } = new(HttpMethod.Get, "/api/v1/admin/analytics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint PlatformDashboardAnalytics { get; } = new(HttpMethod.Get, "/api/v1/admin/analytics/dashboard", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint PlatformDeliverabilityByProvider { get; } = new(HttpMethod.Get, "/api/v1/admin/analytics/providers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListEvents { get; } = new(HttpMethod.Get, "/api/v1/admin/events", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetEvent { get; } = new(HttpMethod.Get, "/api/v1/admin/events/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListScheduledJobs { get; } = new(HttpMethod.Get, "/api/v1/admin/jobs", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint PlatformMetrics { get; } = new(HttpMethod.Get, "/api/v1/admin/metrics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListAllOauthProvidersAdmin { get; } = new(HttpMethod.Get, "/api/v1/admin/oauth/providers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateOauthProvider { get; } = new(HttpMethod.Post, "/api/v1/admin/oauth/providers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteOauthProvider { get; } = new(HttpMethod.Delete, "/api/v1/admin/oauth/providers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateOauthProvider { get; } = new(HttpMethod.Put, "/api/v1/admin/oauth/providers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListPlans { get; } = new(HttpMethod.Get, "/api/v1/admin/plans", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreatePlan { get; } = new(HttpMethod.Post, "/api/v1/admin/plans", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeletePlan { get; } = new(HttpMethod.Delete, "/api/v1/admin/plans/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetPlan { get; } = new(HttpMethod.Get, "/api/v1/admin/plans/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdatePlan { get; } = new(HttpMethod.Put, "/api/v1/admin/plans/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint SetPlanAsDefault { get; } = new(HttpMethod.Patch, "/api/v1/admin/plans/{id}/default", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListSharedSmtpServers { get; } = new(HttpMethod.Get, "/api/v1/admin/servers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateSharedSmtpServer { get; } = new(HttpMethod.Post, "/api/v1/admin/servers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteSharedSmtpServer { get; } = new(HttpMethod.Delete, "/api/v1/admin/servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetSharedSmtpServer { get; } = new(HttpMethod.Get, "/api/v1/admin/servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateSharedSmtpServer { get; } = new(HttpMethod.Put, "/api/v1/admin/servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DisableSharedSmtpServer { get; } = new(HttpMethod.Post, "/api/v1/admin/servers/{id}/disable", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint EnableSharedSmtpServer { get; } = new(HttpMethod.Post, "/api/v1/admin/servers/{id}/enable", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint TestSharedSmtpServerConnection { get; } = new(HttpMethod.Post, "/api/v1/admin/servers/{id}/test", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetPlatformSettings { get; } = new(HttpMethod.Get, "/api/v1/admin/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdatePlatformSettings { get; } = new(HttpMethod.Put, "/api/v1/admin/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetUpdateStatus { get; } = new(HttpMethod.Get, "/api/v1/admin/update", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DismissUpdateNotice { get; } = new(HttpMethod.Post, "/api/v1/admin/update/dismiss", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListAllUsers { get; } = new(HttpMethod.Get, "/api/v1/admin/users", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateANewUser { get; } = new(HttpMethod.Post, "/api/v1/admin/users", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteUser { get; } = new(HttpMethod.Delete, "/api/v1/admin/users/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateUser { get; } = new(HttpMethod.Put, "/api/v1/admin/users/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint Disable2faForUser { get; } = new(HttpMethod.Delete, "/api/v1/admin/users/{id}/2fa", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CancelUserDeletion { get; } = new(HttpMethod.Post, "/api/v1/admin/users/{id}/cancel-deletion", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ForceDeleteUser { get; } = new(HttpMethod.Delete, "/api/v1/admin/users/{id}/force", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetUserMetrics { get; } = new(HttpMethod.Get, "/api/v1/admin/users/{id}/metrics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetUserPlan { get; } = new(HttpMethod.Get, "/api/v1/admin/users/{id}/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint AssignPlanToUser { get; } = new(HttpMethod.Post, "/api/v1/admin/users/{id}/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RevokeAllUserSessions { get; } = new(HttpMethod.Post, "/api/v1/admin/users/{id}/revoke-sessions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListUserWorkspaces { get; } = new(HttpMethod.Get, "/api/v1/admin/users/{id}/workspaces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetWorkspacePlan { get; } = new(HttpMethod.Get, "/api/v1/admin/workspaces/{id}/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint AssignPlanToWorkspace { get; } = new(HttpMethod.Post, "/api/v1/admin/workspaces/{id}/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RequestPasswordReset { get; } = new(HttpMethod.Post, "/api/v1/auth/forgot-password", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint Login { get; } = new(HttpMethod.Post, "/api/v1/auth/login", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint DiscoverSsoProviderByEmail { get; } = new(HttpMethod.Post, "/api/v1/auth/oauth/discover", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint ListOauthProviders { get; } = new(HttpMethod.Get, "/api/v1/auth/oauth/providers", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint InitiateOauthFlow { get; } = new(HttpMethod.Get, "/api/v1/auth/oauth/{provider}/authorize", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint Register { get; } = new(HttpMethod.Post, "/api/v1/auth/register", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint RegistrationStatus { get; } = new(HttpMethod.Get, "/api/v1/auth/registration-status", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint ResetPassword { get; } = new(HttpMethod.Post, "/api/v1/auth/reset-password", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint VerifyEmailAddress { get; } = new(HttpMethod.Get, "/api/v1/auth/verify-email", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint ListBounces { get; } = new(HttpMethod.Get, "/api/v1/bounces", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint ListEmails { get; } = new(HttpMethod.Get, "/api/v1/emails", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint SendBatchEmails { get; } = new(HttpMethod.Post, "/api/v1/emails/batch", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint PreviewEmailFromTemplate { get; } = new(HttpMethod.Post, "/api/v1/emails/preview", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint SendAnEmail { get; } = new(HttpMethod.Post, "/api/v1/emails/send", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint SendEmailUsingTemplate { get; } = new(HttpMethod.Post, "/api/v1/emails/send-template", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint VerifyAnEmailAddress { get; } = new(HttpMethod.Post, "/api/v1/emails/verify", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint GetEmailDetails { get; } = new(HttpMethod.Get, "/api/v1/emails/{id}", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint RetryFailedEmail { get; } = new(HttpMethod.Post, "/api/v1/emails/{id}/retry", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint GetEmailDeliveryStatus { get; } = new(HttpMethod.Get, "/api/v1/emails/{id}/status", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint ReceiveInboundEmailViaWebhook { get; } = new(HttpMethod.Post, "/api/v1/inbound/webhook", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint ApplicationInfo { get; } = new(HttpMethod.Get, "/api/v1/info", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint MyPendingInvitations { get; } = new(HttpMethod.Get, "/api/v1/invitations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint AcceptInvitation { get; } = new(HttpMethod.Post, "/api/v1/invitations/accept", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeclineInvitationByToken { get; } = new(HttpMethod.Post, "/api/v1/invitations/decline", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint AcceptInvitationById { get; } = new(HttpMethod.Post, "/api/v1/invitations/{id}/accept", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeclineInvitationById { get; } = new(HttpMethod.Post, "/api/v1/invitations/{id}/decline", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint SubscribeAnEmailToAList { get; } = new(HttpMethod.Post, "/api/v1/subscriber-lists/subscribe", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint ReSubscribeAnEmailToAList { get; } = new(HttpMethod.Post, "/api/v1/subscriber-lists/{id}/resubscribe", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint UnsubscribeAnEmailFromAList { get; } = new(HttpMethod.Post, "/api/v1/subscriber-lists/{id}/unsubscribe", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint GetCurrentUserProfile { get; } = new(HttpMethod.Get, "/api/v1/users/me", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateProfile { get; } = new(HttpMethod.Put, "/api/v1/users/me", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint Disable2fa { get; } = new(HttpMethod.Post, "/api/v1/users/me/2fa/disable", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint Setup2fa { get; } = new(HttpMethod.Post, "/api/v1/users/me/2fa/setup", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint VerifyAndEnable2fa { get; } = new(HttpMethod.Post, "/api/v1/users/me/2fa/verify", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListUserAuditLog { get; } = new(HttpMethod.Get, "/api/v1/users/me/audit-log", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CancelAccountDeletion { get; } = new(HttpMethod.Post, "/api/v1/users/me/cancel-deletion", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RequestAccountDeletion { get; } = new(HttpMethod.Post, "/api/v1/users/me/delete", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListLinkedOauthAccounts { get; } = new(HttpMethod.Get, "/api/v1/users/me/oauth", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UnlinkOauthAccount { get; } = new(HttpMethod.Delete, "/api/v1/users/me/oauth/{provider_id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ChangePassword { get; } = new(HttpMethod.Put, "/api/v1/users/me/password", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetMyPlan { get; } = new(HttpMethod.Get, "/api/v1/users/me/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListActiveSessions { get; } = new(HttpMethod.Get, "/api/v1/users/me/sessions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint LogoutCurrentSession { get; } = new(HttpMethod.Post, "/api/v1/users/me/sessions/logout", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RevokeAllOtherSessions { get; } = new(HttpMethod.Post, "/api/v1/users/me/sessions/revoke-others", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RevokeSession { get; } = new(HttpMethod.Delete, "/api/v1/users/me/sessions/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetUserSettings { get; } = new(HttpMethod.Get, "/api/v1/users/me/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateUserSettings { get; } = new(HttpMethod.Put, "/api/v1/users/me/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ResendVerificationEmail { get; } = new(HttpMethod.Post, "/api/v1/users/me/verify-email/resend", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListWebhookDeliveries { get; } = new(HttpMethod.Get, "/api/v1/webhook-deliveries", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint ListWebhooks { get; } = new(HttpMethod.Get, "/api/v1/webhooks", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateWebhook { get; } = new(HttpMethod.Post, "/api/v1/webhooks", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint BounceNotificationWebhook { get; } = new(HttpMethod.Post, "/api/v1/webhooks/bounce", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteWebhook { get; } = new(HttpMethod.Delete, "/api/v1/webhooks/{id}", PostaAuthentication.ApiKey);

    /// <inheritdoc />
    public virtual PostaEndpoint ListWorkspaces { get; } = new(HttpMethod.Get, "/api/v1/workspaces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateWorkspace { get; } = new(HttpMethod.Post, "/api/v1/workspaces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteWorkspace { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetCurrentWorkspace { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateWorkspace { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint EmailAnalytics { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/analytics", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DashboardAnalytics { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/analytics/dashboard", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeliverabilityByProvider { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/analytics/providers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListApiKeys { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/api-keys", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateApiKey { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/api-keys", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteApiKey { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/api-keys/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetApiKey { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/api-keys/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RevokeApiKey { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/api-keys/{id}/revoke", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListWorkspaceAuditLog { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/audit-log", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetWorkspaceAuditEvent { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/audit-log/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListBouncesWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/bounces", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RecordABounce { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/bounces", PostaAuthentication.AccessToken);

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

    /// <inheritdoc />
    public virtual PostaEndpoint ListContacts { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/contacts", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetContactDetails { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/contacts/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetDashboardStatistics { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/dashboard/stats", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ExportWorkspaceData { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/data/export", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ImportWorkspaceData { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/data/import", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListDomains { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/domains", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint AddDomain { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/domains", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteDomain { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/domains/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetDomainDetails { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/domains/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint VerifyDomainDnsRecords { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/domains/{id}/verify", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListEmailsWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/emails", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint PreviewEmailFromTemplateWorkspaceResources { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/emails/preview", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetEmailDetailsWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/emails/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RetryFailedEmailWorkspaceResources { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/emails/{id}/retry", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetEmailDeliveryStatusWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/emails/{id}/status", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteWorkspaceContactDataGdpr { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/gdpr/delete-contacts", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteWorkspaceEmailLogsGdpr { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/gdpr/delete-email-logs", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListInboundEmails { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/inbound-emails", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteAnInboundEmail { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/inbound-emails/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetAnInboundEmailByUuid { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/inbound-emails/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DownloadTheRawRfc5322MessageEml { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/inbound-emails/{id}/raw", PostaAuthentication.AccessToken, false, "The Posta 0.11.0 OpenAPI document omits the response content type and schema.");

    /// <inheritdoc />
    public virtual PostaEndpoint RetryWebhookDispatchForAFailedInboundEmail { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/inbound-emails/{id}/retry", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DownloadAnInboundEmailAttachmentAuthenticated { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/inbound-emails/{uuid}/attachments/{idx}", PostaAuthentication.AccessToken, false, "The Posta 0.11.0 OpenAPI document omits the response content type and schema.");

    /// <inheritdoc />
    public virtual PostaEndpoint ListPendingInvitations { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/invitations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint InviteMember { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/invitations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CancelInvitation { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/invitations/{invitation_id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListLanguages { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/languages", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateLanguage { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/languages", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteLanguage { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/languages/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateLanguage { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/languages/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteLocalization { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/localizations/{localizationId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateLocalization { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/localizations/{localizationId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListWorkspaceMembers { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/members", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RemoveMember { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/members/{member_id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateMemberRole { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/members/{member_id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetWorkspacePlanWorkspaces { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/plan", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetWorkspaceSettings { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateWorkspaceSettings { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/settings", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListSmtpServers { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/smtp-servers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint AddSmtpServer { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/smtp-servers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteSmtpServer { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/smtp-servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetSmtpServer { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/smtp-servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateSmtpServer { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/smtp-servers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint TestSmtpServerConnection { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/smtp-servers/{id}/test", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteWorkspaceSsoConfig { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/sso", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetWorkspaceSsoConfig { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/sso", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint SetWorkspaceSsoConfig { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/sso", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListStylesheets { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/stylesheets", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateStylesheet { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/stylesheets", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteStylesheet { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/stylesheets/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateStylesheet { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/stylesheets/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListSubscriberLists { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscriber-lists", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateSubscriberList { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint PreviewSegmentCount { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists/preview-segment", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteSubscriberList { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/subscriber-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetSubscriberList { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscriber-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateSubscriberList { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/subscriber-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RemoveSubscriberFromList { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/subscriber-lists/{id}/members", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListMembersOfSubscriberList { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscriber-lists/{id}/members", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint AddSubscriberToList { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists/{id}/members", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ReSubscribeAnEmailToAListSubscriberLists { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists/{id}/resubscribe", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UnsubscribeAnEmailFromAListSubscriberLists { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscriber-lists/{id}/unsubscribe", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListSubscribers { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscribers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateSubscriber { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscribers", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint BulkImportSubscribersCsv { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscribers/import/csv", PostaAuthentication.AccessToken, false, "The Posta 0.11.0 OpenAPI document omits the multipart request body.");

    /// <inheritdoc />
    public virtual PostaEndpoint BulkImportSubscribersJson { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/subscribers/import/json", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteSubscriber { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/subscribers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetSubscriber { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/subscribers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateSubscriber { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/subscribers/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint RemoveFromSuppressionList { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/suppressions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListSuppressedEmails { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/suppressions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint AddToSuppressionList { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/suppressions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListTemplates { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ImportTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/import", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ImportHtmlTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/import-html", PostaAuthentication.AccessToken, false, "The Posta 0.11.0 OpenAPI document omits the HTML upload request body.");

    /// <inheritdoc />
    public virtual PostaEndpoint PreviewTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/preview", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteTemplate { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/templates/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetTemplate { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateTemplate { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/templates/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ActivateTemplateVersion { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/activate/{versionId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ExportTemplate { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates/{id}/export", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint SendTestEmail { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/send-test", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListTemplateVersions { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates/{id}/versions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateTemplateVersion { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/versions", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteTemplateVersion { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateTemplateVersion { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListLocalizationsForAVersion { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}/localizations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateLocalization { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}/localizations", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint PreviewLocalizedTemplate { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/templates/{id}/versions/{versionId}/preview", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListUnsubscribeLists { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/unsubscribe-lists", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateUnsubscribeList { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/unsubscribe-lists", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteUnsubscribeList { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/unsubscribe-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint GetUnsubscribeList { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/unsubscribe-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint UpdateUnsubscribeList { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/unsubscribe-lists/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListWebhookDeliveriesWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/webhook-deliveries", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint ListWebhooksWorkspaceResources { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/webhooks", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint CreateWebhookUser { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/webhooks", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint DeleteWebhookUser { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/webhooks/{id}", PostaAuthentication.AccessToken);

    /// <inheritdoc />
    public virtual PostaEndpoint LivenessProbe { get; } = new(HttpMethod.Get, "/healthz", PostaAuthentication.None);

    /// <inheritdoc />
    public virtual PostaEndpoint ReadinessProbe { get; } = new(HttpMethod.Get, "/readyz", PostaAuthentication.None);

}
