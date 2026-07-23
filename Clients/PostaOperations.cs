using Posta.Transport;
using Admin = Posta.Models.Admin;
using Auth = Posta.Models.Auth;
using Campaigns = Posta.Models.Campaigns;
using Emails = Posta.Models.Emails;
using Health = Posta.Models.Health;
using Inbound = Posta.Models.Inbound;
using Info = Posta.Models.Info;
using OAuth = Posta.Models.OAuth;
using SubscriberLists = Posta.Models.SubscriberLists;
using Subscribers = Posta.Models.Subscribers;
using Templates = Posta.Models.Templates;
using UnsubscribeLists = Posta.Models.UnsubscribeLists;
using Users = Posta.Models.Users;
using Webhooks = Posta.Models.Webhooks;
using WorkspaceResources = Posta.Models.WorkspaceResources;
using Workspaces = Posta.Models.Workspaces;

namespace Posta.Clients;

/// <summary>Provides admin API operations.</summary>
public interface IPostaAdminClient : IPostaSectionClient
{
    /// <summary>Platform analytics</summary>
    Task<Admin.PlatformAnalyticsResponse?> PlatformAnalyticsAsync(Admin.PlatformAnalyticsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Platform dashboard analytics</summary>
    Task<Admin.PlatformDashboardAnalyticsResponse?> PlatformDashboardAnalyticsAsync(Admin.PlatformDashboardAnalyticsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Platform deliverability by provider</summary>
    Task<Admin.PlatformDeliverabilityByProviderResponse?> PlatformDeliverabilityByProviderAsync(Admin.PlatformDeliverabilityByProviderRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>List events</summary>
    Task<Admin.ListEventsResponse?> ListEventsAsync(Admin.ListEventsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Get event</summary>
    Task<Admin.GetEventResponse?> GetEventAsync(Admin.GetEventRequest request, CancellationToken cancellationToken = default);

    /// <summary>List scheduled jobs</summary>
    Task<Admin.ListScheduledJobsResponse?> ListScheduledJobsAsync(CancellationToken cancellationToken = default);

    /// <summary>Platform metrics</summary>
    Task<Admin.PlatformMetricsResponse?> PlatformMetricsAsync(CancellationToken cancellationToken = default);

    /// <summary>List all OAuth providers (admin)</summary>
    Task<Admin.ListAllOauthProvidersAdminResponse?> ListAllOauthProvidersAdminAsync(CancellationToken cancellationToken = default);

    /// <summary>Create OAuth provider</summary>
    Task<Admin.CreateOauthProviderResponse?> CreateOauthProviderAsync(Admin.CreateOauthProviderRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete OAuth provider</summary>
    Task<Admin.DeleteOauthProviderResponse?> DeleteOauthProviderAsync(Admin.DeleteOauthProviderRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update OAuth provider</summary>
    Task<Admin.UpdateOauthProviderResponse?> UpdateOauthProviderAsync(Admin.UpdateOauthProviderRequest request, CancellationToken cancellationToken = default);

    /// <summary>List plans</summary>
    Task<Admin.ListPlansResponse?> ListPlansAsync(Admin.ListPlansRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create plan</summary>
    Task<Admin.CreatePlanResponse?> CreatePlanAsync(Admin.CreatePlanRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete plan</summary>
    Task<Admin.DeletePlanResponse?> DeletePlanAsync(Admin.DeletePlanRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get plan</summary>
    Task<Admin.GetPlanResponse?> GetPlanAsync(Admin.GetPlanRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update plan</summary>
    Task<Admin.UpdatePlanResponse?> UpdatePlanAsync(Admin.UpdatePlanRequest request, CancellationToken cancellationToken = default);

    /// <summary>Set plan as default</summary>
    Task<Admin.SetPlanAsDefaultResponse?> SetPlanAsDefaultAsync(Admin.SetPlanAsDefaultRequest request, CancellationToken cancellationToken = default);

    /// <summary>List shared SMTP servers</summary>
    Task<Admin.ListSharedSmtpServersResponse?> ListSharedSmtpServersAsync(Admin.ListSharedSmtpServersRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create shared SMTP server</summary>
    Task<Admin.CreateSharedSmtpServerResponse?> CreateSharedSmtpServerAsync(Admin.CreateSharedSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete shared SMTP server</summary>
    Task<Admin.DeleteSharedSmtpServerResponse?> DeleteSharedSmtpServerAsync(Admin.DeleteSharedSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get shared SMTP server</summary>
    Task<Admin.GetSharedSmtpServerResponse?> GetSharedSmtpServerAsync(Admin.GetSharedSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update shared SMTP server</summary>
    Task<Admin.UpdateSharedSmtpServerResponse?> UpdateSharedSmtpServerAsync(Admin.UpdateSharedSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Disable shared SMTP server</summary>
    Task<Admin.DisableSharedSmtpServerResponse?> DisableSharedSmtpServerAsync(Admin.DisableSharedSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Enable shared SMTP server</summary>
    Task<Admin.EnableSharedSmtpServerResponse?> EnableSharedSmtpServerAsync(Admin.EnableSharedSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Test shared SMTP server connection</summary>
    Task<Admin.TestSharedSmtpServerConnectionResponse?> TestSharedSmtpServerConnectionAsync(Admin.TestSharedSmtpServerConnectionRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get platform settings</summary>
    Task<Admin.GetPlatformSettingsResponse?> GetPlatformSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>Update platform settings</summary>
    Task<Admin.UpdatePlatformSettingsResponse?> UpdatePlatformSettingsAsync(Admin.UpdatePlatformSettingsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get the cached Posta update status</summary>
    Task<Admin.GetUpdateStatusResponse?> GetUpdateStatusAsync(CancellationToken cancellationToken = default);

    /// <summary>Dismiss the update notice for a version</summary>
    Task<Admin.DismissUpdateNoticeResponse?> DismissUpdateNoticeAsync(Admin.DismissUpdateNoticeRequest request, CancellationToken cancellationToken = default);

    /// <summary>List all users</summary>
    Task<Admin.ListAllUsersResponse?> ListAllUsersAsync(Admin.ListAllUsersRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create a new user</summary>
    Task<Admin.CreateANewUserResponse?> CreateANewUserAsync(Admin.CreateANewUserRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete user</summary>
    Task<Admin.DeleteUserResponse?> DeleteUserAsync(Admin.DeleteUserRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update user</summary>
    Task<Admin.UpdateUserResponse?> UpdateUserAsync(Admin.UpdateUserRequest request, CancellationToken cancellationToken = default);

    /// <summary>Disable 2FA for user</summary>
    Task<Admin.Disable2faForUserResponse?> Disable2faForUserAsync(Admin.Disable2faForUserRequest request, CancellationToken cancellationToken = default);

    /// <summary>Cancel user deletion</summary>
    Task<Admin.CancelUserDeletionResponse?> CancelUserDeletionAsync(Admin.CancelUserDeletionRequest request, CancellationToken cancellationToken = default);

    /// <summary>Force delete user</summary>
    Task<Admin.ForceDeleteUserResponse?> ForceDeleteUserAsync(Admin.ForceDeleteUserRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get user metrics</summary>
    Task<Admin.GetUserMetricsResponse?> GetUserMetricsAsync(Admin.GetUserMetricsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get user plan</summary>
    Task<Admin.GetUserPlanResponse?> GetUserPlanAsync(Admin.GetUserPlanRequest request, CancellationToken cancellationToken = default);

    /// <summary>Assign plan to user</summary>
    Task<Admin.AssignPlanToUserResponse?> AssignPlanToUserAsync(Admin.AssignPlanToUserRequest request, CancellationToken cancellationToken = default);

    /// <summary>Revoke all user sessions</summary>
    Task<Admin.RevokeAllUserSessionsResponse?> RevokeAllUserSessionsAsync(Admin.RevokeAllUserSessionsRequest request, CancellationToken cancellationToken = default);

    /// <summary>List user workspaces</summary>
    Task<Admin.ListUserWorkspacesResponse?> ListUserWorkspacesAsync(Admin.ListUserWorkspacesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get workspace plan</summary>
    Task<Admin.GetWorkspacePlanResponse?> GetWorkspacePlanAsync(Admin.GetWorkspacePlanRequest request, CancellationToken cancellationToken = default);

    /// <summary>Assign plan to workspace</summary>
    Task<Admin.AssignPlanToWorkspaceResponse?> AssignPlanToWorkspaceAsync(Admin.AssignPlanToWorkspaceRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides auth API operations.</summary>
public interface IPostaAuthClient : IPostaSectionClient
{
    /// <summary>Request password reset</summary>
    Task<Auth.RequestPasswordResetResponse?> RequestPasswordResetAsync(Auth.RequestPasswordResetRequest request, CancellationToken cancellationToken = default);

    /// <summary>Login</summary>
    Task<Auth.LoginResponse?> LoginAsync(Auth.LoginRequest request, CancellationToken cancellationToken = default);

    /// <summary>Register</summary>
    Task<Auth.RegisterResponse?> RegisterAsync(Auth.RegisterRequest request, CancellationToken cancellationToken = default);

    /// <summary>Registration status</summary>
    Task<Auth.RegistrationStatusResponse?> RegistrationStatusAsync(CancellationToken cancellationToken = default);

    /// <summary>Reset password</summary>
    Task<Auth.ResetPasswordResponse?> ResetPasswordAsync(Auth.ResetPasswordRequest request, CancellationToken cancellationToken = default);

    /// <summary>Verify email address</summary>
    Task<Auth.VerifyEmailAddressResponse?> VerifyEmailAddressAsync(Auth.VerifyEmailAddressRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides campaigns API operations.</summary>
public interface IPostaCampaignsClient : IPostaSectionClient
{
    /// <summary>List campaigns</summary>
    Task<Campaigns.ListCampaignsResponse?> ListCampaignsAsync(Campaigns.ListCampaignsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create campaign</summary>
    Task<Campaigns.CreateCampaignResponse?> CreateCampaignAsync(Campaigns.CreateCampaignRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete campaign</summary>
    Task<Campaigns.DeleteCampaignResponse?> DeleteCampaignAsync(Campaigns.DeleteCampaignRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get campaign</summary>
    Task<Campaigns.GetCampaignResponse?> GetCampaignAsync(Campaigns.GetCampaignRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update campaign</summary>
    Task<Campaigns.UpdateCampaignResponse?> UpdateCampaignAsync(Campaigns.UpdateCampaignRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get campaign analytics</summary>
    Task<Campaigns.GetCampaignAnalyticsResponse?> GetCampaignAnalyticsAsync(Campaigns.GetCampaignAnalyticsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Cancel campaign</summary>
    Task<Campaigns.CancelCampaignResponse?> CancelCampaignAsync(Campaigns.CancelCampaignRequest request, CancellationToken cancellationToken = default);

    /// <summary>Duplicate campaign</summary>
    Task<Campaigns.DuplicateCampaignResponse?> DuplicateCampaignAsync(Campaigns.DuplicateCampaignRequest request, CancellationToken cancellationToken = default);

    /// <summary>List campaign messages</summary>
    Task<Campaigns.ListCampaignMessagesResponse?> ListCampaignMessagesAsync(Campaigns.ListCampaignMessagesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Pause campaign</summary>
    Task<Campaigns.PauseCampaignResponse?> PauseCampaignAsync(Campaigns.PauseCampaignRequest request, CancellationToken cancellationToken = default);

    /// <summary>Resume campaign</summary>
    Task<Campaigns.ResumeCampaignResponse?> ResumeCampaignAsync(Campaigns.ResumeCampaignRequest request, CancellationToken cancellationToken = default);

    /// <summary>Send campaign</summary>
    Task<Campaigns.SendCampaignResponse?> SendCampaignAsync(Campaigns.SendCampaignRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides emails API operations.</summary>
public interface IPostaEmailsClient : IPostaSectionClient
{
    /// <summary>List bounces</summary>
    Task<Emails.ListBouncesResponse?> ListBouncesAsync(Emails.ListBouncesRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>List emails</summary>
    Task<Emails.ListEmailsResponse?> ListEmailsAsync(Emails.ListEmailsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Send batch emails</summary>
    Task<Emails.SendBatchEmailsResponse?> SendBatchEmailsAsync(Emails.SendBatchEmailsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Preview email from template</summary>
    Task<Emails.PreviewEmailFromTemplateResponse?> PreviewEmailFromTemplateAsync(Emails.PreviewEmailFromTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Send an email</summary>
    Task<Emails.SendAnEmailResponse?> SendAnEmailAsync(Emails.SendAnEmailRequest request, CancellationToken cancellationToken = default);

    /// <summary>Send email using template</summary>
    Task<Emails.SendEmailUsingTemplateResponse?> SendEmailUsingTemplateAsync(Emails.SendEmailUsingTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Verify an email address</summary>
    Task<Emails.VerifyAnEmailAddressResponse?> VerifyAnEmailAddressAsync(Emails.VerifyAnEmailAddressRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get email details</summary>
    Task<Emails.GetEmailDetailsResponse?> GetEmailDetailsAsync(Emails.GetEmailDetailsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retry failed email</summary>
    Task<Emails.RetryFailedEmailResponse?> RetryFailedEmailAsync(Emails.RetryFailedEmailRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get email delivery status</summary>
    Task<Emails.GetEmailDeliveryStatusResponse?> GetEmailDeliveryStatusAsync(Emails.GetEmailDeliveryStatusRequest request, CancellationToken cancellationToken = default);

    /// <summary>List emails</summary>
    Task<Emails.ListEmailsWorkspaceResourcesResponse?> ListEmailsWorkspaceResourcesAsync(Emails.ListEmailsWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Preview email from template</summary>
    Task<Emails.PreviewEmailFromTemplateWorkspaceResourcesResponse?> PreviewEmailFromTemplateWorkspaceResourcesAsync(Emails.PreviewEmailFromTemplateWorkspaceResourcesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get email details</summary>
    Task<Emails.GetEmailDetailsWorkspaceResourcesResponse?> GetEmailDetailsWorkspaceResourcesAsync(Emails.GetEmailDetailsWorkspaceResourcesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retry failed email</summary>
    Task<Emails.RetryFailedEmailWorkspaceResourcesResponse?> RetryFailedEmailWorkspaceResourcesAsync(Emails.RetryFailedEmailWorkspaceResourcesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get email delivery status</summary>
    Task<Emails.GetEmailDeliveryStatusWorkspaceResourcesResponse?> GetEmailDeliveryStatusWorkspaceResourcesAsync(Emails.GetEmailDeliveryStatusWorkspaceResourcesRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides health API operations.</summary>
public interface IPostaHealthClient : IPostaSectionClient
{
    /// <summary>Liveness probe</summary>
    Task<Health.LivenessProbeResponse?> LivenessProbeAsync(CancellationToken cancellationToken = default);

    /// <summary>Readiness probe</summary>
    Task<Health.ReadinessProbeResponse?> ReadinessProbeAsync(CancellationToken cancellationToken = default);

}

/// <summary>Provides inbound API operations.</summary>
public interface IPostaInboundClient : IPostaSectionClient
{
    /// <summary>Receive inbound email via webhook</summary>
    Task<Inbound.ReceiveInboundEmailViaWebhookResponse?> ReceiveInboundEmailViaWebhookAsync(Inbound.ReceiveInboundEmailViaWebhookRequest request, CancellationToken cancellationToken = default);

    /// <summary>List inbound emails</summary>
    Task<Inbound.ListInboundEmailsResponse?> ListInboundEmailsAsync(Inbound.ListInboundEmailsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Delete an inbound email</summary>
    Task<Inbound.DeleteAnInboundEmailResponse?> DeleteAnInboundEmailAsync(Inbound.DeleteAnInboundEmailRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get an inbound email by UUID</summary>
    Task<Inbound.GetAnInboundEmailByUuidResponse?> GetAnInboundEmailByUuidAsync(Inbound.GetAnInboundEmailByUuidRequest request, CancellationToken cancellationToken = default);

    /// <summary>Download the raw RFC 5322 message (.eml)</summary>
    Task<Inbound.DownloadTheRawRfc5322MessageEmlResponse?> DownloadTheRawRfc5322MessageEmlAsync(Inbound.DownloadTheRawRfc5322MessageEmlRequest request, CancellationToken cancellationToken = default);

    /// <summary>Retry webhook dispatch for a failed inbound email</summary>
    Task<Inbound.RetryWebhookDispatchForAFailedInboundEmailResponse?> RetryWebhookDispatchForAFailedInboundEmailAsync(Inbound.RetryWebhookDispatchForAFailedInboundEmailRequest request, CancellationToken cancellationToken = default);

    /// <summary>Download an inbound email attachment (authenticated)</summary>
    Task<Inbound.DownloadAnInboundEmailAttachmentAuthenticatedResponse?> DownloadAnInboundEmailAttachmentAuthenticatedAsync(Inbound.DownloadAnInboundEmailAttachmentAuthenticatedRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides info API operations.</summary>
public interface IPostaInfoClient : IPostaSectionClient
{
    /// <summary>Application info</summary>
    Task<Info.ApplicationInfoResponse?> ApplicationInfoAsync(CancellationToken cancellationToken = default);

}

/// <summary>Provides oauth API operations.</summary>
public interface IPostaOAuthClient : IPostaSectionClient
{
    /// <summary>Discover SSO provider by email</summary>
    Task<OAuth.DiscoverSsoProviderByEmailResponse?> DiscoverSsoProviderByEmailAsync(OAuth.DiscoverSsoProviderByEmailRequest request, CancellationToken cancellationToken = default);

    /// <summary>List OAuth providers</summary>
    Task<OAuth.ListOauthProvidersResponse?> ListOauthProvidersAsync(CancellationToken cancellationToken = default);

    /// <summary>Initiate OAuth flow</summary>
    Task<OAuth.InitiateOauthFlowResponse?> InitiateOauthFlowAsync(OAuth.InitiateOauthFlowRequest request, CancellationToken cancellationToken = default);

    /// <summary>List linked OAuth accounts</summary>
    Task<OAuth.ListLinkedOauthAccountsResponse?> ListLinkedOauthAccountsAsync(CancellationToken cancellationToken = default);

    /// <summary>Unlink OAuth account</summary>
    Task<OAuth.UnlinkOauthAccountResponse?> UnlinkOauthAccountAsync(OAuth.UnlinkOauthAccountRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides subscriberlists API operations.</summary>
public interface IPostaSubscriberListsClient : IPostaSectionClient
{
    /// <summary>Subscribe an email to a list</summary>
    Task<SubscriberLists.SubscribeAnEmailToAListResponse?> SubscribeAnEmailToAListAsync(SubscriberLists.SubscribeAnEmailToAListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Re-subscribe an email to a list</summary>
    Task<SubscriberLists.ReSubscribeAnEmailToAListResponse?> ReSubscribeAnEmailToAListAsync(SubscriberLists.ReSubscribeAnEmailToAListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Unsubscribe an email from a list</summary>
    Task<SubscriberLists.UnsubscribeAnEmailFromAListResponse?> UnsubscribeAnEmailFromAListAsync(SubscriberLists.UnsubscribeAnEmailFromAListRequest request, CancellationToken cancellationToken = default);

    /// <summary>List subscriber lists</summary>
    Task<SubscriberLists.ListSubscriberListsResponse?> ListSubscriberListsAsync(SubscriberLists.ListSubscriberListsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create subscriber list</summary>
    Task<SubscriberLists.CreateSubscriberListResponse?> CreateSubscriberListAsync(SubscriberLists.CreateSubscriberListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Preview segment count</summary>
    Task<SubscriberLists.PreviewSegmentCountResponse?> PreviewSegmentCountAsync(SubscriberLists.PreviewSegmentCountRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete subscriber list</summary>
    Task<SubscriberLists.DeleteSubscriberListResponse?> DeleteSubscriberListAsync(SubscriberLists.DeleteSubscriberListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get subscriber list</summary>
    Task<SubscriberLists.GetSubscriberListResponse?> GetSubscriberListAsync(SubscriberLists.GetSubscriberListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update subscriber list</summary>
    Task<SubscriberLists.UpdateSubscriberListResponse?> UpdateSubscriberListAsync(SubscriberLists.UpdateSubscriberListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Remove subscriber from list</summary>
    Task<SubscriberLists.RemoveSubscriberFromListResponse?> RemoveSubscriberFromListAsync(SubscriberLists.RemoveSubscriberFromListRequest request, CancellationToken cancellationToken = default);

    /// <summary>List members of subscriber list</summary>
    Task<SubscriberLists.ListMembersOfSubscriberListResponse?> ListMembersOfSubscriberListAsync(SubscriberLists.ListMembersOfSubscriberListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Add subscriber to list</summary>
    Task<SubscriberLists.AddSubscriberToListResponse?> AddSubscriberToListAsync(SubscriberLists.AddSubscriberToListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Re-subscribe an email to a list</summary>
    Task<SubscriberLists.ReSubscribeAnEmailToAListSubscriberListsResponse?> ReSubscribeAnEmailToAListSubscriberListsAsync(SubscriberLists.ReSubscribeAnEmailToAListSubscriberListsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Unsubscribe an email from a list</summary>
    Task<SubscriberLists.UnsubscribeAnEmailFromAListSubscriberListsResponse?> UnsubscribeAnEmailFromAListSubscriberListsAsync(SubscriberLists.UnsubscribeAnEmailFromAListSubscriberListsRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides subscribers API operations.</summary>
public interface IPostaSubscribersClient : IPostaSectionClient
{
    /// <summary>List subscribers</summary>
    Task<Subscribers.ListSubscribersResponse?> ListSubscribersAsync(Subscribers.ListSubscribersRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create subscriber</summary>
    Task<Subscribers.CreateSubscriberResponse?> CreateSubscriberAsync(Subscribers.CreateSubscriberRequest request, CancellationToken cancellationToken = default);

    /// <summary>Bulk import subscribers (CSV)</summary>
    Task<Subscribers.BulkImportSubscribersCsvResponse?> BulkImportSubscribersCsvAsync(CancellationToken cancellationToken = default);

    /// <summary>Bulk import subscribers (JSON)</summary>
    Task<Subscribers.BulkImportSubscribersJsonResponse?> BulkImportSubscribersJsonAsync(Subscribers.BulkImportSubscribersJsonRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete subscriber</summary>
    Task<Subscribers.DeleteSubscriberResponse?> DeleteSubscriberAsync(Subscribers.DeleteSubscriberRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get subscriber</summary>
    Task<Subscribers.GetSubscriberResponse?> GetSubscriberAsync(Subscribers.GetSubscriberRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update subscriber</summary>
    Task<Subscribers.UpdateSubscriberResponse?> UpdateSubscriberAsync(Subscribers.UpdateSubscriberRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides templates API operations.</summary>
public interface IPostaTemplatesClient : IPostaSectionClient
{
    /// <summary>Delete localization</summary>
    Task<Templates.DeleteLocalizationResponse?> DeleteLocalizationAsync(Templates.DeleteLocalizationRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update localization</summary>
    Task<Templates.UpdateLocalizationResponse?> UpdateLocalizationAsync(Templates.UpdateLocalizationRequest request, CancellationToken cancellationToken = default);

    /// <summary>List stylesheets</summary>
    Task<Templates.ListStylesheetsResponse?> ListStylesheetsAsync(Templates.ListStylesheetsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create stylesheet</summary>
    Task<Templates.CreateStylesheetResponse?> CreateStylesheetAsync(Templates.CreateStylesheetRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete stylesheet</summary>
    Task<Templates.DeleteStylesheetResponse?> DeleteStylesheetAsync(Templates.DeleteStylesheetRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update stylesheet</summary>
    Task<Templates.UpdateStylesheetResponse?> UpdateStylesheetAsync(Templates.UpdateStylesheetRequest request, CancellationToken cancellationToken = default);

    /// <summary>List templates</summary>
    Task<Templates.ListTemplatesResponse?> ListTemplatesAsync(Templates.ListTemplatesRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create template</summary>
    Task<Templates.CreateTemplateResponse?> CreateTemplateAsync(Templates.CreateTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Import template</summary>
    Task<Templates.ImportTemplateResponse?> ImportTemplateAsync(Templates.ImportTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Import HTML template</summary>
    Task<Templates.ImportHtmlTemplateResponse?> ImportHtmlTemplateAsync(CancellationToken cancellationToken = default);

    /// <summary>Preview template</summary>
    Task<Templates.PreviewTemplateResponse?> PreviewTemplateAsync(Templates.PreviewTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete template</summary>
    Task<Templates.DeleteTemplateResponse?> DeleteTemplateAsync(Templates.DeleteTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get template</summary>
    Task<Templates.GetTemplateResponse?> GetTemplateAsync(Templates.GetTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update template</summary>
    Task<Templates.UpdateTemplateResponse?> UpdateTemplateAsync(Templates.UpdateTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Activate template version</summary>
    Task<Templates.ActivateTemplateVersionResponse?> ActivateTemplateVersionAsync(Templates.ActivateTemplateVersionRequest request, CancellationToken cancellationToken = default);

    /// <summary>Export template</summary>
    Task<Templates.ExportTemplateResponse?> ExportTemplateAsync(Templates.ExportTemplateRequest request, CancellationToken cancellationToken = default);

    /// <summary>Send test email</summary>
    Task<Templates.SendTestEmailResponse?> SendTestEmailAsync(Templates.SendTestEmailRequest request, CancellationToken cancellationToken = default);

    /// <summary>List template versions</summary>
    Task<Templates.ListTemplateVersionsResponse?> ListTemplateVersionsAsync(Templates.ListTemplateVersionsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Create template version</summary>
    Task<Templates.CreateTemplateVersionResponse?> CreateTemplateVersionAsync(Templates.CreateTemplateVersionRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete template version</summary>
    Task<Templates.DeleteTemplateVersionResponse?> DeleteTemplateVersionAsync(Templates.DeleteTemplateVersionRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update template version</summary>
    Task<Templates.UpdateTemplateVersionResponse?> UpdateTemplateVersionAsync(Templates.UpdateTemplateVersionRequest request, CancellationToken cancellationToken = default);

    /// <summary>List localizations for a version</summary>
    Task<Templates.ListLocalizationsForAVersionResponse?> ListLocalizationsForAVersionAsync(Templates.ListLocalizationsForAVersionRequest request, CancellationToken cancellationToken = default);

    /// <summary>Create localization</summary>
    Task<Templates.CreateLocalizationResponse?> CreateLocalizationAsync(Templates.CreateLocalizationRequest request, CancellationToken cancellationToken = default);

    /// <summary>Preview localized template</summary>
    Task<Templates.PreviewLocalizedTemplateResponse?> PreviewLocalizedTemplateAsync(Templates.PreviewLocalizedTemplateRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides unsubscribelists API operations.</summary>
public interface IPostaUnsubscribeListsClient : IPostaSectionClient
{
    /// <summary>List unsubscribe lists</summary>
    Task<UnsubscribeLists.ListUnsubscribeListsResponse?> ListUnsubscribeListsAsync(UnsubscribeLists.ListUnsubscribeListsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create unsubscribe list</summary>
    Task<UnsubscribeLists.CreateUnsubscribeListResponse?> CreateUnsubscribeListAsync(UnsubscribeLists.CreateUnsubscribeListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete unsubscribe list</summary>
    Task<UnsubscribeLists.DeleteUnsubscribeListResponse?> DeleteUnsubscribeListAsync(UnsubscribeLists.DeleteUnsubscribeListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get unsubscribe list</summary>
    Task<UnsubscribeLists.GetUnsubscribeListResponse?> GetUnsubscribeListAsync(UnsubscribeLists.GetUnsubscribeListRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update unsubscribe list</summary>
    Task<UnsubscribeLists.UpdateUnsubscribeListResponse?> UpdateUnsubscribeListAsync(UnsubscribeLists.UpdateUnsubscribeListRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides users API operations.</summary>
public interface IPostaUsersClient : IPostaSectionClient
{
    /// <summary>Get current user profile</summary>
    Task<Users.GetCurrentUserProfileResponse?> GetCurrentUserProfileAsync(CancellationToken cancellationToken = default);

    /// <summary>Update profile</summary>
    Task<Users.UpdateProfileResponse?> UpdateProfileAsync(Users.UpdateProfileRequest request, CancellationToken cancellationToken = default);

    /// <summary>Disable 2FA</summary>
    Task<Users.Disable2faResponse?> Disable2faAsync(Users.Disable2faRequest request, CancellationToken cancellationToken = default);

    /// <summary>Setup 2FA</summary>
    Task<Users.Setup2faResponse?> Setup2faAsync(CancellationToken cancellationToken = default);

    /// <summary>Verify and enable 2FA</summary>
    Task<Users.VerifyAndEnable2faResponse?> VerifyAndEnable2faAsync(Users.VerifyAndEnable2faRequest request, CancellationToken cancellationToken = default);

    /// <summary>List user audit log</summary>
    Task<Users.ListUserAuditLogResponse?> ListUserAuditLogAsync(Users.ListUserAuditLogRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Cancel account deletion</summary>
    Task<Users.CancelAccountDeletionResponse?> CancelAccountDeletionAsync(CancellationToken cancellationToken = default);

    /// <summary>Request account deletion</summary>
    Task<Users.RequestAccountDeletionResponse?> RequestAccountDeletionAsync(CancellationToken cancellationToken = default);

    /// <summary>Change password</summary>
    Task<Users.ChangePasswordResponse?> ChangePasswordAsync(Users.ChangePasswordRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get my plan</summary>
    Task<Users.GetMyPlanResponse?> GetMyPlanAsync(CancellationToken cancellationToken = default);

    /// <summary>List active sessions</summary>
    Task<Users.ListActiveSessionsResponse?> ListActiveSessionsAsync(CancellationToken cancellationToken = default);

    /// <summary>Logout current session</summary>
    Task<Users.LogoutCurrentSessionResponse?> LogoutCurrentSessionAsync(CancellationToken cancellationToken = default);

    /// <summary>Revoke all other sessions</summary>
    Task<Users.RevokeAllOtherSessionsResponse?> RevokeAllOtherSessionsAsync(CancellationToken cancellationToken = default);

    /// <summary>Revoke session</summary>
    Task<Users.RevokeSessionResponse?> RevokeSessionAsync(Users.RevokeSessionRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get user settings</summary>
    Task<Users.GetUserSettingsResponse?> GetUserSettingsAsync(CancellationToken cancellationToken = default);

    /// <summary>Update user settings</summary>
    Task<Users.UpdateUserSettingsResponse?> UpdateUserSettingsAsync(Users.UpdateUserSettingsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Resend verification email</summary>
    Task<Users.ResendVerificationEmailResponse?> ResendVerificationEmailAsync(CancellationToken cancellationToken = default);

}

/// <summary>Provides webhooks API operations.</summary>
public interface IPostaWebhooksClient : IPostaSectionClient
{
    /// <summary>List webhook deliveries</summary>
    Task<Webhooks.ListWebhookDeliveriesResponse?> ListWebhookDeliveriesAsync(Webhooks.ListWebhookDeliveriesRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>List webhooks</summary>
    Task<Webhooks.ListWebhooksResponse?> ListWebhooksAsync(Webhooks.ListWebhooksRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create webhook</summary>
    Task<Webhooks.CreateWebhookResponse?> CreateWebhookAsync(Webhooks.CreateWebhookRequest request, CancellationToken cancellationToken = default);

    /// <summary>Bounce notification webhook</summary>
    Task<Webhooks.BounceNotificationWebhookResponse?> BounceNotificationWebhookAsync(Webhooks.BounceNotificationWebhookRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete webhook</summary>
    Task<Webhooks.DeleteWebhookResponse?> DeleteWebhookAsync(Webhooks.DeleteWebhookRequest request, CancellationToken cancellationToken = default);

    /// <summary>List webhook deliveries</summary>
    Task<Webhooks.ListWebhookDeliveriesWorkspaceResourcesResponse?> ListWebhookDeliveriesWorkspaceResourcesAsync(Webhooks.ListWebhookDeliveriesWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>List webhooks</summary>
    Task<Webhooks.ListWebhooksWorkspaceResourcesResponse?> ListWebhooksWorkspaceResourcesAsync(Webhooks.ListWebhooksWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create webhook</summary>
    Task<Webhooks.CreateWebhookUserResponse?> CreateWebhookUserAsync(Webhooks.CreateWebhookUserRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete webhook</summary>
    Task<Webhooks.DeleteWebhookUserResponse?> DeleteWebhookUserAsync(Webhooks.DeleteWebhookUserRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides workspaceresources API operations.</summary>
public interface IPostaWorkspaceResourcesClient : IPostaSectionClient
{
    /// <summary>Email analytics</summary>
    Task<WorkspaceResources.EmailAnalyticsResponse?> EmailAnalyticsAsync(WorkspaceResources.EmailAnalyticsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Dashboard analytics</summary>
    Task<WorkspaceResources.DashboardAnalyticsResponse?> DashboardAnalyticsAsync(WorkspaceResources.DashboardAnalyticsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Deliverability by provider</summary>
    Task<WorkspaceResources.DeliverabilityByProviderResponse?> DeliverabilityByProviderAsync(WorkspaceResources.DeliverabilityByProviderRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>List API keys</summary>
    Task<WorkspaceResources.ListApiKeysResponse?> ListApiKeysAsync(WorkspaceResources.ListApiKeysRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create API key</summary>
    Task<WorkspaceResources.CreateApiKeyResponse?> CreateApiKeyAsync(WorkspaceResources.CreateApiKeyRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete API key</summary>
    Task<WorkspaceResources.DeleteApiKeyResponse?> DeleteApiKeyAsync(WorkspaceResources.DeleteApiKeyRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get API key</summary>
    Task<WorkspaceResources.GetApiKeyResponse?> GetApiKeyAsync(WorkspaceResources.GetApiKeyRequest request, CancellationToken cancellationToken = default);

    /// <summary>Revoke API key</summary>
    Task<WorkspaceResources.RevokeApiKeyResponse?> RevokeApiKeyAsync(WorkspaceResources.RevokeApiKeyRequest request, CancellationToken cancellationToken = default);

    /// <summary>List bounces</summary>
    Task<WorkspaceResources.ListBouncesWorkspaceResourcesResponse?> ListBouncesWorkspaceResourcesAsync(WorkspaceResources.ListBouncesWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Record a bounce</summary>
    Task<WorkspaceResources.RecordABounceResponse?> RecordABounceAsync(WorkspaceResources.RecordABounceRequest request, CancellationToken cancellationToken = default);

    /// <summary>List contacts</summary>
    Task<WorkspaceResources.ListContactsResponse?> ListContactsAsync(WorkspaceResources.ListContactsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Get contact details</summary>
    Task<WorkspaceResources.GetContactDetailsResponse?> GetContactDetailsAsync(WorkspaceResources.GetContactDetailsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get dashboard statistics</summary>
    Task<WorkspaceResources.GetDashboardStatisticsResponse?> GetDashboardStatisticsAsync(CancellationToken cancellationToken = default);

    /// <summary>List domains</summary>
    Task<WorkspaceResources.ListDomainsResponse?> ListDomainsAsync(WorkspaceResources.ListDomainsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Add domain</summary>
    Task<WorkspaceResources.AddDomainResponse?> AddDomainAsync(WorkspaceResources.AddDomainRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete domain</summary>
    Task<WorkspaceResources.DeleteDomainResponse?> DeleteDomainAsync(WorkspaceResources.DeleteDomainRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get domain details</summary>
    Task<WorkspaceResources.GetDomainDetailsResponse?> GetDomainDetailsAsync(WorkspaceResources.GetDomainDetailsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Verify domain DNS records</summary>
    Task<WorkspaceResources.VerifyDomainDnsRecordsResponse?> VerifyDomainDnsRecordsAsync(WorkspaceResources.VerifyDomainDnsRecordsRequest request, CancellationToken cancellationToken = default);

    /// <summary>List languages</summary>
    Task<WorkspaceResources.ListLanguagesResponse?> ListLanguagesAsync(WorkspaceResources.ListLanguagesRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Create language</summary>
    Task<WorkspaceResources.CreateLanguageResponse?> CreateLanguageAsync(WorkspaceResources.CreateLanguageRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete language</summary>
    Task<WorkspaceResources.DeleteLanguageResponse?> DeleteLanguageAsync(WorkspaceResources.DeleteLanguageRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update language</summary>
    Task<WorkspaceResources.UpdateLanguageResponse?> UpdateLanguageAsync(WorkspaceResources.UpdateLanguageRequest request, CancellationToken cancellationToken = default);

    /// <summary>List SMTP servers</summary>
    Task<WorkspaceResources.ListSmtpServersResponse?> ListSmtpServersAsync(WorkspaceResources.ListSmtpServersRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Add SMTP server</summary>
    Task<WorkspaceResources.AddSmtpServerResponse?> AddSmtpServerAsync(WorkspaceResources.AddSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete SMTP server</summary>
    Task<WorkspaceResources.DeleteSmtpServerResponse?> DeleteSmtpServerAsync(WorkspaceResources.DeleteSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get SMTP server</summary>
    Task<WorkspaceResources.GetSmtpServerResponse?> GetSmtpServerAsync(WorkspaceResources.GetSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update SMTP server</summary>
    Task<WorkspaceResources.UpdateSmtpServerResponse?> UpdateSmtpServerAsync(WorkspaceResources.UpdateSmtpServerRequest request, CancellationToken cancellationToken = default);

    /// <summary>Test SMTP server connection</summary>
    Task<WorkspaceResources.TestSmtpServerConnectionResponse?> TestSmtpServerConnectionAsync(WorkspaceResources.TestSmtpServerConnectionRequest request, CancellationToken cancellationToken = default);

    /// <summary>Remove from suppression list</summary>
    Task<WorkspaceResources.RemoveFromSuppressionListResponse?> RemoveFromSuppressionListAsync(WorkspaceResources.RemoveFromSuppressionListRequest request, CancellationToken cancellationToken = default);

    /// <summary>List suppressed emails</summary>
    Task<WorkspaceResources.ListSuppressedEmailsResponse?> ListSuppressedEmailsAsync(WorkspaceResources.ListSuppressedEmailsRequest? request = null, CancellationToken cancellationToken = default);

    /// <summary>Add to suppression list</summary>
    Task<WorkspaceResources.AddToSuppressionListResponse?> AddToSuppressionListAsync(WorkspaceResources.AddToSuppressionListRequest request, CancellationToken cancellationToken = default);

}

/// <summary>Provides workspaces API operations.</summary>
public interface IPostaWorkspacesClient : IPostaSectionClient
{
    /// <summary>My pending invitations</summary>
    Task<Workspaces.MyPendingInvitationsResponse?> MyPendingInvitationsAsync(CancellationToken cancellationToken = default);

    /// <summary>Accept invitation</summary>
    Task<Workspaces.AcceptInvitationResponse?> AcceptInvitationAsync(Workspaces.AcceptInvitationRequest request, CancellationToken cancellationToken = default);

    /// <summary>Decline invitation by token</summary>
    Task<Workspaces.DeclineInvitationByTokenResponse?> DeclineInvitationByTokenAsync(Workspaces.DeclineInvitationByTokenRequest request, CancellationToken cancellationToken = default);

    /// <summary>Accept invitation by ID</summary>
    Task<Workspaces.AcceptInvitationByIdResponse?> AcceptInvitationByIdAsync(Workspaces.AcceptInvitationByIdRequest request, CancellationToken cancellationToken = default);

    /// <summary>Decline invitation by ID</summary>
    Task<Workspaces.DeclineInvitationByIdResponse?> DeclineInvitationByIdAsync(Workspaces.DeclineInvitationByIdRequest request, CancellationToken cancellationToken = default);

    /// <summary>List workspaces</summary>
    Task<Workspaces.ListWorkspacesResponse?> ListWorkspacesAsync(CancellationToken cancellationToken = default);

    /// <summary>Create workspace</summary>
    Task<Workspaces.CreateWorkspaceResponse?> CreateWorkspaceAsync(Workspaces.CreateWorkspaceRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete workspace</summary>
    Task<Workspaces.DeleteWorkspaceResponse?> DeleteWorkspaceAsync(Workspaces.DeleteWorkspaceRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get current workspace</summary>
    Task<Workspaces.GetCurrentWorkspaceResponse?> GetCurrentWorkspaceAsync(Workspaces.GetCurrentWorkspaceRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update workspace</summary>
    Task<Workspaces.UpdateWorkspaceResponse?> UpdateWorkspaceAsync(Workspaces.UpdateWorkspaceRequest request, CancellationToken cancellationToken = default);

    /// <summary>List workspace audit log</summary>
    Task<Workspaces.ListWorkspaceAuditLogResponse?> ListWorkspaceAuditLogAsync(Workspaces.ListWorkspaceAuditLogRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get workspace audit event</summary>
    Task<Workspaces.GetWorkspaceAuditEventResponse?> GetWorkspaceAuditEventAsync(Workspaces.GetWorkspaceAuditEventRequest request, CancellationToken cancellationToken = default);

    /// <summary>Export workspace data</summary>
    Task<Workspaces.ExportWorkspaceDataResponse?> ExportWorkspaceDataAsync(Workspaces.ExportWorkspaceDataRequest request, CancellationToken cancellationToken = default);

    /// <summary>Import workspace data</summary>
    Task<Workspaces.ImportWorkspaceDataResponse?> ImportWorkspaceDataAsync(Workspaces.ImportWorkspaceDataRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete workspace contact data (GDPR)</summary>
    Task<Workspaces.DeleteWorkspaceContactDataGdprResponse?> DeleteWorkspaceContactDataGdprAsync(Workspaces.DeleteWorkspaceContactDataGdprRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete workspace email logs (GDPR)</summary>
    Task<Workspaces.DeleteWorkspaceEmailLogsGdprResponse?> DeleteWorkspaceEmailLogsGdprAsync(Workspaces.DeleteWorkspaceEmailLogsGdprRequest request, CancellationToken cancellationToken = default);

    /// <summary>List pending invitations</summary>
    Task<Workspaces.ListPendingInvitationsResponse?> ListPendingInvitationsAsync(Workspaces.ListPendingInvitationsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Invite member</summary>
    Task<Workspaces.InviteMemberResponse?> InviteMemberAsync(Workspaces.InviteMemberRequest request, CancellationToken cancellationToken = default);

    /// <summary>Cancel invitation</summary>
    Task<Workspaces.CancelInvitationResponse?> CancelInvitationAsync(Workspaces.CancelInvitationRequest request, CancellationToken cancellationToken = default);

    /// <summary>List workspace members</summary>
    Task<Workspaces.ListWorkspaceMembersResponse?> ListWorkspaceMembersAsync(Workspaces.ListWorkspaceMembersRequest request, CancellationToken cancellationToken = default);

    /// <summary>Remove member</summary>
    Task<Workspaces.RemoveMemberResponse?> RemoveMemberAsync(Workspaces.RemoveMemberRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update member role</summary>
    Task<Workspaces.UpdateMemberRoleResponse?> UpdateMemberRoleAsync(Workspaces.UpdateMemberRoleRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get workspace plan</summary>
    Task<Workspaces.GetWorkspacePlanWorkspacesResponse?> GetWorkspacePlanWorkspacesAsync(Workspaces.GetWorkspacePlanWorkspacesRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get workspace settings</summary>
    Task<Workspaces.GetWorkspaceSettingsResponse?> GetWorkspaceSettingsAsync(Workspaces.GetWorkspaceSettingsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Update workspace settings</summary>
    Task<Workspaces.UpdateWorkspaceSettingsResponse?> UpdateWorkspaceSettingsAsync(Workspaces.UpdateWorkspaceSettingsRequest request, CancellationToken cancellationToken = default);

    /// <summary>Delete workspace SSO config</summary>
    Task<Workspaces.DeleteWorkspaceSsoConfigResponse?> DeleteWorkspaceSsoConfigAsync(Workspaces.DeleteWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default);

    /// <summary>Get workspace SSO config</summary>
    Task<Workspaces.GetWorkspaceSsoConfigResponse?> GetWorkspaceSsoConfigAsync(Workspaces.GetWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default);

    /// <summary>Set workspace SSO config</summary>
    Task<Workspaces.SetWorkspaceSsoConfigResponse?> SetWorkspaceSsoConfigAsync(Workspaces.SetWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default);

}

internal sealed partial class PostaClientSection
{
    public Task<Admin.PlatformAnalyticsResponse?> PlatformAnalyticsAsync(Admin.PlatformAnalyticsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<Admin.PlatformAnalyticsResponse>(_endpoints.PlatformAnalytics, postaRequest, cancellationToken);
    }

    public Task<Admin.PlatformDashboardAnalyticsResponse?> PlatformDashboardAnalyticsAsync(Admin.PlatformDashboardAnalyticsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
            },
        };

        return SendAsync<Admin.PlatformDashboardAnalyticsResponse>(_endpoints.PlatformDashboardAnalytics, postaRequest, cancellationToken);
    }

    public Task<Admin.PlatformDeliverabilityByProviderResponse?> PlatformDeliverabilityByProviderAsync(Admin.PlatformDeliverabilityByProviderRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
            },
        };

        return SendAsync<Admin.PlatformDeliverabilityByProviderResponse>(_endpoints.PlatformDeliverabilityByProvider, postaRequest, cancellationToken);
    }

    public Task<Admin.ListEventsResponse?> ListEventsAsync(Admin.ListEventsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["category"] = request?.Category,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Admin.ListEventsResponse>(_endpoints.ListEvents, postaRequest, cancellationToken);
    }

    public Task<Admin.GetEventResponse?> GetEventAsync(Admin.GetEventRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetEventResponse>(_endpoints.GetEvent, postaRequest, cancellationToken);
    }

    public Task<Admin.ListScheduledJobsResponse?> ListScheduledJobsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.ListScheduledJobsResponse>(_endpoints.ListScheduledJobs, null, cancellationToken);
    }

    public Task<Admin.PlatformMetricsResponse?> PlatformMetricsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.PlatformMetricsResponse>(_endpoints.PlatformMetrics, null, cancellationToken);
    }

    public Task<Admin.ListAllOauthProvidersAdminResponse?> ListAllOauthProvidersAdminAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.ListAllOauthProvidersAdminResponse>(_endpoints.ListAllOauthProvidersAdmin, null, cancellationToken);
    }

    public Task<Admin.CreateOauthProviderResponse?> CreateOauthProviderAsync(Admin.CreateOauthProviderRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.CreateOauthProviderResponse>(_endpoints.CreateOauthProvider, postaRequest, cancellationToken);
    }

    public Task<Admin.DeleteOauthProviderResponse?> DeleteOauthProviderAsync(Admin.DeleteOauthProviderRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.DeleteOauthProviderResponse>(_endpoints.DeleteOauthProvider, postaRequest, cancellationToken);
    }

    public Task<Admin.UpdateOauthProviderResponse?> UpdateOauthProviderAsync(Admin.UpdateOauthProviderRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.UpdateOauthProviderResponse>(_endpoints.UpdateOauthProvider, postaRequest, cancellationToken);
    }

    public Task<Admin.ListPlansResponse?> ListPlansAsync(Admin.ListPlansRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Admin.ListPlansResponse>(_endpoints.ListPlans, postaRequest, cancellationToken);
    }

    public Task<Admin.CreatePlanResponse?> CreatePlanAsync(Admin.CreatePlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.CreatePlanResponse>(_endpoints.CreatePlan, postaRequest, cancellationToken);
    }

    public Task<Admin.DeletePlanResponse?> DeletePlanAsync(Admin.DeletePlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
            Query = new Dictionary<string, object?>
            {
                ["force"] = request?.Force,
            },
        };

        return SendAsync<Admin.DeletePlanResponse>(_endpoints.DeletePlan, postaRequest, cancellationToken);
    }

    public Task<Admin.GetPlanResponse?> GetPlanAsync(Admin.GetPlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetPlanResponse>(_endpoints.GetPlan, postaRequest, cancellationToken);
    }

    public Task<Admin.UpdatePlanResponse?> UpdatePlanAsync(Admin.UpdatePlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.UpdatePlanResponse>(_endpoints.UpdatePlan, postaRequest, cancellationToken);
    }

    public Task<Admin.SetPlanAsDefaultResponse?> SetPlanAsDefaultAsync(Admin.SetPlanAsDefaultRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.SetPlanAsDefaultResponse>(_endpoints.SetPlanAsDefault, postaRequest, cancellationToken);
    }

    public Task<Admin.ListSharedSmtpServersResponse?> ListSharedSmtpServersAsync(Admin.ListSharedSmtpServersRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Admin.ListSharedSmtpServersResponse>(_endpoints.ListSharedSmtpServers, postaRequest, cancellationToken);
    }

    public Task<Admin.CreateSharedSmtpServerResponse?> CreateSharedSmtpServerAsync(Admin.CreateSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.CreateSharedSmtpServerResponse>(_endpoints.CreateSharedSmtpServer, postaRequest, cancellationToken);
    }

    public Task<Admin.DeleteSharedSmtpServerResponse?> DeleteSharedSmtpServerAsync(Admin.DeleteSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.DeleteSharedSmtpServerResponse>(_endpoints.DeleteSharedSmtpServer, postaRequest, cancellationToken);
    }

    public Task<Admin.GetSharedSmtpServerResponse?> GetSharedSmtpServerAsync(Admin.GetSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetSharedSmtpServerResponse>(_endpoints.GetSharedSmtpServer, postaRequest, cancellationToken);
    }

    public Task<Admin.UpdateSharedSmtpServerResponse?> UpdateSharedSmtpServerAsync(Admin.UpdateSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.UpdateSharedSmtpServerResponse>(_endpoints.UpdateSharedSmtpServer, postaRequest, cancellationToken);
    }

    public Task<Admin.DisableSharedSmtpServerResponse?> DisableSharedSmtpServerAsync(Admin.DisableSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.DisableSharedSmtpServerResponse>(_endpoints.DisableSharedSmtpServer, postaRequest, cancellationToken);
    }

    public Task<Admin.EnableSharedSmtpServerResponse?> EnableSharedSmtpServerAsync(Admin.EnableSharedSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.EnableSharedSmtpServerResponse>(_endpoints.EnableSharedSmtpServer, postaRequest, cancellationToken);
    }

    public Task<Admin.TestSharedSmtpServerConnectionResponse?> TestSharedSmtpServerConnectionAsync(Admin.TestSharedSmtpServerConnectionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.TestSharedSmtpServerConnectionResponse>(_endpoints.TestSharedSmtpServerConnection, postaRequest, cancellationToken);
    }

    public Task<Admin.GetPlatformSettingsResponse?> GetPlatformSettingsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.GetPlatformSettingsResponse>(_endpoints.GetPlatformSettings, null, cancellationToken);
    }

    public Task<Admin.UpdatePlatformSettingsResponse?> UpdatePlatformSettingsAsync(Admin.UpdatePlatformSettingsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.UpdatePlatformSettingsResponse>(_endpoints.UpdatePlatformSettings, postaRequest, cancellationToken);
    }

    public Task<Admin.GetUpdateStatusResponse?> GetUpdateStatusAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Admin.GetUpdateStatusResponse>(_endpoints.GetUpdateStatus, null, cancellationToken);
    }

    public Task<Admin.DismissUpdateNoticeResponse?> DismissUpdateNoticeAsync(Admin.DismissUpdateNoticeRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.DismissUpdateNoticeResponse>(_endpoints.DismissUpdateNotice, postaRequest, cancellationToken);
    }

    public Task<Admin.ListAllUsersResponse?> ListAllUsersAsync(Admin.ListAllUsersRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Admin.ListAllUsersResponse>(_endpoints.ListAllUsers, postaRequest, cancellationToken);
    }

    public Task<Admin.CreateANewUserResponse?> CreateANewUserAsync(Admin.CreateANewUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Admin.CreateANewUserResponse>(_endpoints.CreateANewUser, postaRequest, cancellationToken);
    }

    public Task<Admin.DeleteUserResponse?> DeleteUserAsync(Admin.DeleteUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.DeleteUserResponse>(_endpoints.DeleteUser, postaRequest, cancellationToken);
    }

    public Task<Admin.UpdateUserResponse?> UpdateUserAsync(Admin.UpdateUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.UpdateUserResponse>(_endpoints.UpdateUser, postaRequest, cancellationToken);
    }

    public Task<Admin.Disable2faForUserResponse?> Disable2faForUserAsync(Admin.Disable2faForUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.Disable2faForUserResponse>(_endpoints.Disable2faForUser, postaRequest, cancellationToken);
    }

    public Task<Admin.CancelUserDeletionResponse?> CancelUserDeletionAsync(Admin.CancelUserDeletionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.CancelUserDeletionResponse>(_endpoints.CancelUserDeletion, postaRequest, cancellationToken);
    }

    public Task<Admin.ForceDeleteUserResponse?> ForceDeleteUserAsync(Admin.ForceDeleteUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.ForceDeleteUserResponse>(_endpoints.ForceDeleteUser, postaRequest, cancellationToken);
    }

    public Task<Admin.GetUserMetricsResponse?> GetUserMetricsAsync(Admin.GetUserMetricsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetUserMetricsResponse>(_endpoints.GetUserMetrics, postaRequest, cancellationToken);
    }

    public Task<Admin.GetUserPlanResponse?> GetUserPlanAsync(Admin.GetUserPlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetUserPlanResponse>(_endpoints.GetUserPlan, postaRequest, cancellationToken);
    }

    public Task<Admin.AssignPlanToUserResponse?> AssignPlanToUserAsync(Admin.AssignPlanToUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.AssignPlanToUserResponse>(_endpoints.AssignPlanToUser, postaRequest, cancellationToken);
    }

    public Task<Admin.RevokeAllUserSessionsResponse?> RevokeAllUserSessionsAsync(Admin.RevokeAllUserSessionsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.RevokeAllUserSessionsResponse>(_endpoints.RevokeAllUserSessions, postaRequest, cancellationToken);
    }

    public Task<Admin.ListUserWorkspacesResponse?> ListUserWorkspacesAsync(Admin.ListUserWorkspacesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.ListUserWorkspacesResponse>(_endpoints.ListUserWorkspaces, postaRequest, cancellationToken);
    }

    public Task<Admin.GetWorkspacePlanResponse?> GetWorkspacePlanAsync(Admin.GetWorkspacePlanRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.GetWorkspacePlanResponse>(_endpoints.GetWorkspacePlan, postaRequest, cancellationToken);
    }

    public Task<Admin.AssignPlanToWorkspaceResponse?> AssignPlanToWorkspaceAsync(Admin.AssignPlanToWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Admin.AssignPlanToWorkspaceResponse>(_endpoints.AssignPlanToWorkspace, postaRequest, cancellationToken);
    }

    public Task<Auth.RequestPasswordResetResponse?> RequestPasswordResetAsync(Auth.RequestPasswordResetRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Auth.RequestPasswordResetResponse>(_endpoints.RequestPasswordReset, postaRequest, cancellationToken);
    }

    public Task<Auth.LoginResponse?> LoginAsync(Auth.LoginRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Auth.LoginResponse>(_endpoints.Login, postaRequest, cancellationToken);
    }

    public Task<OAuth.DiscoverSsoProviderByEmailResponse?> DiscoverSsoProviderByEmailAsync(OAuth.DiscoverSsoProviderByEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<OAuth.DiscoverSsoProviderByEmailResponse>(_endpoints.DiscoverSsoProviderByEmail, postaRequest, cancellationToken);
    }

    public Task<OAuth.ListOauthProvidersResponse?> ListOauthProvidersAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<OAuth.ListOauthProvidersResponse>(_endpoints.ListOauthProviders, null, cancellationToken);
    }

    public Task<OAuth.InitiateOauthFlowResponse?> InitiateOauthFlowAsync(OAuth.InitiateOauthFlowRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["provider"] = request?.Provider,
            },
        };

        return SendAsync<OAuth.InitiateOauthFlowResponse>(_endpoints.InitiateOauthFlow, postaRequest, cancellationToken);
    }

    public Task<Auth.RegisterResponse?> RegisterAsync(Auth.RegisterRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Auth.RegisterResponse>(_endpoints.Register, postaRequest, cancellationToken);
    }

    public Task<Auth.RegistrationStatusResponse?> RegistrationStatusAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Auth.RegistrationStatusResponse>(_endpoints.RegistrationStatus, null, cancellationToken);
    }

    public Task<Auth.ResetPasswordResponse?> ResetPasswordAsync(Auth.ResetPasswordRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Auth.ResetPasswordResponse>(_endpoints.ResetPassword, postaRequest, cancellationToken);
    }

    public Task<Auth.VerifyEmailAddressResponse?> VerifyEmailAddressAsync(Auth.VerifyEmailAddressRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["token"] = request?.Token,
            },
        };

        return SendAsync<Auth.VerifyEmailAddressResponse>(_endpoints.VerifyEmailAddress, postaRequest, cancellationToken);
    }

    public Task<Emails.ListBouncesResponse?> ListBouncesAsync(Emails.ListBouncesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<Emails.ListBouncesResponse>(_endpoints.ListBounces, postaRequest, cancellationToken);
    }

    public Task<Emails.ListEmailsResponse?> ListEmailsAsync(Emails.ListEmailsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<Emails.ListEmailsResponse>(_endpoints.ListEmails, postaRequest, cancellationToken);
    }

    public Task<Emails.SendBatchEmailsResponse?> SendBatchEmailsAsync(Emails.SendBatchEmailsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Query = new Dictionary<string, object?>
            {
                ["dry_run"] = request?.DryRun,
            },
        };

        return SendAsync<Emails.SendBatchEmailsResponse>(_endpoints.SendBatchEmails, postaRequest, cancellationToken);
    }

    public Task<Emails.PreviewEmailFromTemplateResponse?> PreviewEmailFromTemplateAsync(Emails.PreviewEmailFromTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Emails.PreviewEmailFromTemplateResponse>(_endpoints.PreviewEmailFromTemplate, postaRequest, cancellationToken);
    }

    public Task<Emails.SendAnEmailResponse?> SendAnEmailAsync(Emails.SendAnEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Query = new Dictionary<string, object?>
            {
                ["dry_run"] = request?.DryRun,
            },
        };

        return SendAsync<Emails.SendAnEmailResponse>(_endpoints.SendAnEmail, postaRequest, cancellationToken);
    }

    public Task<Emails.SendEmailUsingTemplateResponse?> SendEmailUsingTemplateAsync(Emails.SendEmailUsingTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Query = new Dictionary<string, object?>
            {
                ["dry_run"] = request?.DryRun,
            },
        };

        return SendAsync<Emails.SendEmailUsingTemplateResponse>(_endpoints.SendEmailUsingTemplate, postaRequest, cancellationToken);
    }

    public Task<Emails.VerifyAnEmailAddressResponse?> VerifyAnEmailAddressAsync(Emails.VerifyAnEmailAddressRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Query = new Dictionary<string, object?>
            {
                ["fresh"] = request?.Fresh,
            },
        };

        return SendAsync<Emails.VerifyAnEmailAddressResponse>(_endpoints.VerifyAnEmailAddress, postaRequest, cancellationToken);
    }

    public Task<Emails.GetEmailDetailsResponse?> GetEmailDetailsAsync(Emails.GetEmailDetailsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.GetEmailDetailsResponse>(_endpoints.GetEmailDetails, postaRequest, cancellationToken);
    }

    public Task<Emails.RetryFailedEmailResponse?> RetryFailedEmailAsync(Emails.RetryFailedEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.RetryFailedEmailResponse>(_endpoints.RetryFailedEmail, postaRequest, cancellationToken);
    }

    public Task<Emails.GetEmailDeliveryStatusResponse?> GetEmailDeliveryStatusAsync(Emails.GetEmailDeliveryStatusRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.GetEmailDeliveryStatusResponse>(_endpoints.GetEmailDeliveryStatus, postaRequest, cancellationToken);
    }

    public Task<Inbound.ReceiveInboundEmailViaWebhookResponse?> ReceiveInboundEmailViaWebhookAsync(Inbound.ReceiveInboundEmailViaWebhookRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Inbound-Secret"] = Convert.ToString(request?.XPostaInboundSecret, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Inbound.ReceiveInboundEmailViaWebhookResponse>(_endpoints.ReceiveInboundEmailViaWebhook, postaRequest, cancellationToken);
    }

    public Task<Info.ApplicationInfoResponse?> ApplicationInfoAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Info.ApplicationInfoResponse>(_endpoints.ApplicationInfo, null, cancellationToken);
    }

    public Task<Workspaces.MyPendingInvitationsResponse?> MyPendingInvitationsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Workspaces.MyPendingInvitationsResponse>(_endpoints.MyPendingInvitations, null, cancellationToken);
    }

    public Task<Workspaces.AcceptInvitationResponse?> AcceptInvitationAsync(Workspaces.AcceptInvitationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Workspaces.AcceptInvitationResponse>(_endpoints.AcceptInvitation, postaRequest, cancellationToken);
    }

    public Task<Workspaces.DeclineInvitationByTokenResponse?> DeclineInvitationByTokenAsync(Workspaces.DeclineInvitationByTokenRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Workspaces.DeclineInvitationByTokenResponse>(_endpoints.DeclineInvitationByToken, postaRequest, cancellationToken);
    }

    public Task<Workspaces.AcceptInvitationByIdResponse?> AcceptInvitationByIdAsync(Workspaces.AcceptInvitationByIdRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Workspaces.AcceptInvitationByIdResponse>(_endpoints.AcceptInvitationById, postaRequest, cancellationToken);
    }

    public Task<Workspaces.DeclineInvitationByIdResponse?> DeclineInvitationByIdAsync(Workspaces.DeclineInvitationByIdRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Workspaces.DeclineInvitationByIdResponse>(_endpoints.DeclineInvitationById, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.SubscribeAnEmailToAListResponse?> SubscribeAnEmailToAListAsync(SubscriberLists.SubscribeAnEmailToAListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<SubscriberLists.SubscribeAnEmailToAListResponse>(_endpoints.SubscribeAnEmailToAList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.ReSubscribeAnEmailToAListResponse?> ReSubscribeAnEmailToAListAsync(SubscriberLists.ReSubscribeAnEmailToAListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.ReSubscribeAnEmailToAListResponse>(_endpoints.ReSubscribeAnEmailToAList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.UnsubscribeAnEmailFromAListResponse?> UnsubscribeAnEmailFromAListAsync(SubscriberLists.UnsubscribeAnEmailFromAListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.UnsubscribeAnEmailFromAListResponse>(_endpoints.UnsubscribeAnEmailFromAList, postaRequest, cancellationToken);
    }

    public Task<Users.GetCurrentUserProfileResponse?> GetCurrentUserProfileAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.GetCurrentUserProfileResponse>(_endpoints.GetCurrentUserProfile, null, cancellationToken);
    }

    public Task<Users.UpdateProfileResponse?> UpdateProfileAsync(Users.UpdateProfileRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.UpdateProfileResponse>(_endpoints.UpdateProfile, postaRequest, cancellationToken);
    }

    public Task<Users.Disable2faResponse?> Disable2faAsync(Users.Disable2faRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.Disable2faResponse>(_endpoints.Disable2fa, postaRequest, cancellationToken);
    }

    public Task<Users.Setup2faResponse?> Setup2faAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.Setup2faResponse>(_endpoints.Setup2fa, null, cancellationToken);
    }

    public Task<Users.VerifyAndEnable2faResponse?> VerifyAndEnable2faAsync(Users.VerifyAndEnable2faRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.VerifyAndEnable2faResponse>(_endpoints.VerifyAndEnable2fa, postaRequest, cancellationToken);
    }

    public Task<Users.ListUserAuditLogResponse?> ListUserAuditLogAsync(Users.ListUserAuditLogRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["category"] = request?.Category,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Users.ListUserAuditLogResponse>(_endpoints.ListUserAuditLog, postaRequest, cancellationToken);
    }

    public Task<Users.CancelAccountDeletionResponse?> CancelAccountDeletionAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.CancelAccountDeletionResponse>(_endpoints.CancelAccountDeletion, null, cancellationToken);
    }

    public Task<Users.RequestAccountDeletionResponse?> RequestAccountDeletionAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.RequestAccountDeletionResponse>(_endpoints.RequestAccountDeletion, null, cancellationToken);
    }

    public Task<OAuth.ListLinkedOauthAccountsResponse?> ListLinkedOauthAccountsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<OAuth.ListLinkedOauthAccountsResponse>(_endpoints.ListLinkedOauthAccounts, null, cancellationToken);
    }

    public Task<OAuth.UnlinkOauthAccountResponse?> UnlinkOauthAccountAsync(OAuth.UnlinkOauthAccountRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["provider_id"] = request?.ProviderId,
            },
        };

        return SendAsync<OAuth.UnlinkOauthAccountResponse>(_endpoints.UnlinkOauthAccount, postaRequest, cancellationToken);
    }

    public Task<Users.ChangePasswordResponse?> ChangePasswordAsync(Users.ChangePasswordRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.ChangePasswordResponse>(_endpoints.ChangePassword, postaRequest, cancellationToken);
    }

    public Task<Users.GetMyPlanResponse?> GetMyPlanAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.GetMyPlanResponse>(_endpoints.GetMyPlan, null, cancellationToken);
    }

    public Task<Users.ListActiveSessionsResponse?> ListActiveSessionsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.ListActiveSessionsResponse>(_endpoints.ListActiveSessions, null, cancellationToken);
    }

    public Task<Users.LogoutCurrentSessionResponse?> LogoutCurrentSessionAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.LogoutCurrentSessionResponse>(_endpoints.LogoutCurrentSession, null, cancellationToken);
    }

    public Task<Users.RevokeAllOtherSessionsResponse?> RevokeAllOtherSessionsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.RevokeAllOtherSessionsResponse>(_endpoints.RevokeAllOtherSessions, null, cancellationToken);
    }

    public Task<Users.RevokeSessionResponse?> RevokeSessionAsync(Users.RevokeSessionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Users.RevokeSessionResponse>(_endpoints.RevokeSession, postaRequest, cancellationToken);
    }

    public Task<Users.GetUserSettingsResponse?> GetUserSettingsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.GetUserSettingsResponse>(_endpoints.GetUserSettings, null, cancellationToken);
    }

    public Task<Users.UpdateUserSettingsResponse?> UpdateUserSettingsAsync(Users.UpdateUserSettingsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Users.UpdateUserSettingsResponse>(_endpoints.UpdateUserSettings, postaRequest, cancellationToken);
    }

    public Task<Users.ResendVerificationEmailResponse?> ResendVerificationEmailAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Users.ResendVerificationEmailResponse>(_endpoints.ResendVerificationEmail, null, cancellationToken);
    }

    public Task<Webhooks.ListWebhookDeliveriesResponse?> ListWebhookDeliveriesAsync(Webhooks.ListWebhookDeliveriesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<Webhooks.ListWebhookDeliveriesResponse>(_endpoints.ListWebhookDeliveries, postaRequest, cancellationToken);
    }

    public Task<Webhooks.ListWebhooksResponse?> ListWebhooksAsync(Webhooks.ListWebhooksRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<Webhooks.ListWebhooksResponse>(_endpoints.ListWebhooks, postaRequest, cancellationToken);
    }

    public Task<Webhooks.CreateWebhookResponse?> CreateWebhookAsync(Webhooks.CreateWebhookRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Webhooks.CreateWebhookResponse>(_endpoints.CreateWebhook, postaRequest, cancellationToken);
    }

    public Task<Webhooks.BounceNotificationWebhookResponse?> BounceNotificationWebhookAsync(Webhooks.BounceNotificationWebhookRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Webhooks.BounceNotificationWebhookResponse>(_endpoints.BounceNotificationWebhook, postaRequest, cancellationToken);
    }

    public Task<Webhooks.DeleteWebhookResponse?> DeleteWebhookAsync(Webhooks.DeleteWebhookRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Webhooks.DeleteWebhookResponse>(_endpoints.DeleteWebhook, postaRequest, cancellationToken);
    }

    public Task<Workspaces.ListWorkspacesResponse?> ListWorkspacesAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Workspaces.ListWorkspacesResponse>(_endpoints.ListWorkspaces, null, cancellationToken);
    }

    public Task<Workspaces.CreateWorkspaceResponse?> CreateWorkspaceAsync(Workspaces.CreateWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Workspaces.CreateWorkspaceResponse>(_endpoints.CreateWorkspace, postaRequest, cancellationToken);
    }

    public Task<Workspaces.DeleteWorkspaceResponse?> DeleteWorkspaceAsync(Workspaces.DeleteWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.DeleteWorkspaceResponse>(_endpoints.DeleteWorkspace, postaRequest, cancellationToken);
    }

    public Task<Workspaces.GetCurrentWorkspaceResponse?> GetCurrentWorkspaceAsync(Workspaces.GetCurrentWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetCurrentWorkspaceResponse>(_endpoints.GetCurrentWorkspace, postaRequest, cancellationToken);
    }

    public Task<Workspaces.UpdateWorkspaceResponse?> UpdateWorkspaceAsync(Workspaces.UpdateWorkspaceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.UpdateWorkspaceResponse>(_endpoints.UpdateWorkspace, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.EmailAnalyticsResponse?> EmailAnalyticsAsync(WorkspaceResources.EmailAnalyticsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<WorkspaceResources.EmailAnalyticsResponse>(_endpoints.EmailAnalytics, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.DashboardAnalyticsResponse?> DashboardAnalyticsAsync(WorkspaceResources.DashboardAnalyticsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
            },
        };

        return SendAsync<WorkspaceResources.DashboardAnalyticsResponse>(_endpoints.DashboardAnalytics, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.DeliverabilityByProviderResponse?> DeliverabilityByProviderAsync(WorkspaceResources.DeliverabilityByProviderRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["from"] = request?.From,
                ["to"] = request?.To,
            },
        };

        return SendAsync<WorkspaceResources.DeliverabilityByProviderResponse>(_endpoints.DeliverabilityByProvider, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.ListApiKeysResponse?> ListApiKeysAsync(WorkspaceResources.ListApiKeysRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<WorkspaceResources.ListApiKeysResponse>(_endpoints.ListApiKeys, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.CreateApiKeyResponse?> CreateApiKeyAsync(WorkspaceResources.CreateApiKeyRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.CreateApiKeyResponse>(_endpoints.CreateApiKey, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.DeleteApiKeyResponse?> DeleteApiKeyAsync(WorkspaceResources.DeleteApiKeyRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.DeleteApiKeyResponse>(_endpoints.DeleteApiKey, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.GetApiKeyResponse?> GetApiKeyAsync(WorkspaceResources.GetApiKeyRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.GetApiKeyResponse>(_endpoints.GetApiKey, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.RevokeApiKeyResponse?> RevokeApiKeyAsync(WorkspaceResources.RevokeApiKeyRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.RevokeApiKeyResponse>(_endpoints.RevokeApiKey, postaRequest, cancellationToken);
    }

    public Task<Workspaces.ListWorkspaceAuditLogResponse?> ListWorkspaceAuditLogAsync(Workspaces.ListWorkspaceAuditLogRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["category"] = request?.Category,
                ["search"] = request?.Search,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ListWorkspaceAuditLogResponse>(_endpoints.ListWorkspaceAuditLog, postaRequest, cancellationToken);
    }

    public Task<Workspaces.GetWorkspaceAuditEventResponse?> GetWorkspaceAuditEventAsync(Workspaces.GetWorkspaceAuditEventRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetWorkspaceAuditEventResponse>(_endpoints.GetWorkspaceAuditEvent, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.ListBouncesWorkspaceResourcesResponse?> ListBouncesWorkspaceResourcesAsync(WorkspaceResources.ListBouncesWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<WorkspaceResources.ListBouncesWorkspaceResourcesResponse>(_endpoints.ListBouncesWorkspaceResources, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.RecordABounceResponse?> RecordABounceAsync(WorkspaceResources.RecordABounceRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.RecordABounceResponse>(_endpoints.RecordABounce, postaRequest, cancellationToken);
    }

    public Task<Campaigns.ListCampaignsResponse?> ListCampaignsAsync(Campaigns.ListCampaignsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<Campaigns.ListCampaignsResponse>(_endpoints.ListCampaigns, postaRequest, cancellationToken);
    }

    public Task<Campaigns.CreateCampaignResponse?> CreateCampaignAsync(Campaigns.CreateCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Campaigns.CreateCampaignResponse>(_endpoints.CreateCampaign, postaRequest, cancellationToken);
    }

    public Task<Campaigns.DeleteCampaignResponse?> DeleteCampaignAsync(Campaigns.DeleteCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.DeleteCampaignResponse>(_endpoints.DeleteCampaign, postaRequest, cancellationToken);
    }

    public Task<Campaigns.GetCampaignResponse?> GetCampaignAsync(Campaigns.GetCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.GetCampaignResponse>(_endpoints.GetCampaign, postaRequest, cancellationToken);
    }

    public Task<Campaigns.UpdateCampaignResponse?> UpdateCampaignAsync(Campaigns.UpdateCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.UpdateCampaignResponse>(_endpoints.UpdateCampaign, postaRequest, cancellationToken);
    }

    public Task<Campaigns.GetCampaignAnalyticsResponse?> GetCampaignAnalyticsAsync(Campaigns.GetCampaignAnalyticsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.GetCampaignAnalyticsResponse>(_endpoints.GetCampaignAnalytics, postaRequest, cancellationToken);
    }

    public Task<Campaigns.CancelCampaignResponse?> CancelCampaignAsync(Campaigns.CancelCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.CancelCampaignResponse>(_endpoints.CancelCampaign, postaRequest, cancellationToken);
    }

    public Task<Campaigns.DuplicateCampaignResponse?> DuplicateCampaignAsync(Campaigns.DuplicateCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.DuplicateCampaignResponse>(_endpoints.DuplicateCampaign, postaRequest, cancellationToken);
    }

    public Task<Campaigns.ListCampaignMessagesResponse?> ListCampaignMessagesAsync(Campaigns.ListCampaignMessagesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<Campaigns.ListCampaignMessagesResponse>(_endpoints.ListCampaignMessages, postaRequest, cancellationToken);
    }

    public Task<Campaigns.PauseCampaignResponse?> PauseCampaignAsync(Campaigns.PauseCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.PauseCampaignResponse>(_endpoints.PauseCampaign, postaRequest, cancellationToken);
    }

    public Task<Campaigns.ResumeCampaignResponse?> ResumeCampaignAsync(Campaigns.ResumeCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.ResumeCampaignResponse>(_endpoints.ResumeCampaign, postaRequest, cancellationToken);
    }

    public Task<Campaigns.SendCampaignResponse?> SendCampaignAsync(Campaigns.SendCampaignRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Campaigns.SendCampaignResponse>(_endpoints.SendCampaign, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.ListContactsResponse?> ListContactsAsync(WorkspaceResources.ListContactsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<WorkspaceResources.ListContactsResponse>(_endpoints.ListContacts, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.GetContactDetailsResponse?> GetContactDetailsAsync(WorkspaceResources.GetContactDetailsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.GetContactDetailsResponse>(_endpoints.GetContactDetails, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.GetDashboardStatisticsResponse?> GetDashboardStatisticsAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<WorkspaceResources.GetDashboardStatisticsResponse>(_endpoints.GetDashboardStatistics, null, cancellationToken);
    }

    public Task<Workspaces.ExportWorkspaceDataResponse?> ExportWorkspaceDataAsync(Workspaces.ExportWorkspaceDataRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ExportWorkspaceDataResponse>(_endpoints.ExportWorkspaceData, postaRequest, cancellationToken);
    }

    public Task<Workspaces.ImportWorkspaceDataResponse?> ImportWorkspaceDataAsync(Workspaces.ImportWorkspaceDataRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ImportWorkspaceDataResponse>(_endpoints.ImportWorkspaceData, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.ListDomainsResponse?> ListDomainsAsync(WorkspaceResources.ListDomainsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<WorkspaceResources.ListDomainsResponse>(_endpoints.ListDomains, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.AddDomainResponse?> AddDomainAsync(WorkspaceResources.AddDomainRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.AddDomainResponse>(_endpoints.AddDomain, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.DeleteDomainResponse?> DeleteDomainAsync(WorkspaceResources.DeleteDomainRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.DeleteDomainResponse>(_endpoints.DeleteDomain, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.GetDomainDetailsResponse?> GetDomainDetailsAsync(WorkspaceResources.GetDomainDetailsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.GetDomainDetailsResponse>(_endpoints.GetDomainDetails, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.VerifyDomainDnsRecordsResponse?> VerifyDomainDnsRecordsAsync(WorkspaceResources.VerifyDomainDnsRecordsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.VerifyDomainDnsRecordsResponse>(_endpoints.VerifyDomainDnsRecords, postaRequest, cancellationToken);
    }

    public Task<Emails.ListEmailsWorkspaceResourcesResponse?> ListEmailsWorkspaceResourcesAsync(Emails.ListEmailsWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<Emails.ListEmailsWorkspaceResourcesResponse>(_endpoints.ListEmailsWorkspaceResources, postaRequest, cancellationToken);
    }

    public Task<Emails.PreviewEmailFromTemplateWorkspaceResourcesResponse?> PreviewEmailFromTemplateWorkspaceResourcesAsync(Emails.PreviewEmailFromTemplateWorkspaceResourcesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Emails.PreviewEmailFromTemplateWorkspaceResourcesResponse>(_endpoints.PreviewEmailFromTemplateWorkspaceResources, postaRequest, cancellationToken);
    }

    public Task<Emails.GetEmailDetailsWorkspaceResourcesResponse?> GetEmailDetailsWorkspaceResourcesAsync(Emails.GetEmailDetailsWorkspaceResourcesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.GetEmailDetailsWorkspaceResourcesResponse>(_endpoints.GetEmailDetailsWorkspaceResources, postaRequest, cancellationToken);
    }

    public Task<Emails.RetryFailedEmailWorkspaceResourcesResponse?> RetryFailedEmailWorkspaceResourcesAsync(Emails.RetryFailedEmailWorkspaceResourcesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.RetryFailedEmailWorkspaceResourcesResponse>(_endpoints.RetryFailedEmailWorkspaceResources, postaRequest, cancellationToken);
    }

    public Task<Emails.GetEmailDeliveryStatusWorkspaceResourcesResponse?> GetEmailDeliveryStatusWorkspaceResourcesAsync(Emails.GetEmailDeliveryStatusWorkspaceResourcesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Emails.GetEmailDeliveryStatusWorkspaceResourcesResponse>(_endpoints.GetEmailDeliveryStatusWorkspaceResources, postaRequest, cancellationToken);
    }

    public Task<Workspaces.DeleteWorkspaceContactDataGdprResponse?> DeleteWorkspaceContactDataGdprAsync(Workspaces.DeleteWorkspaceContactDataGdprRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.DeleteWorkspaceContactDataGdprResponse>(_endpoints.DeleteWorkspaceContactDataGdpr, postaRequest, cancellationToken);
    }

    public Task<Workspaces.DeleteWorkspaceEmailLogsGdprResponse?> DeleteWorkspaceEmailLogsGdprAsync(Workspaces.DeleteWorkspaceEmailLogsGdprRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.DeleteWorkspaceEmailLogsGdprResponse>(_endpoints.DeleteWorkspaceEmailLogsGdpr, postaRequest, cancellationToken);
    }

    public Task<Inbound.ListInboundEmailsResponse?> ListInboundEmailsAsync(Inbound.ListInboundEmailsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["status"] = request?.Status,
                ["source"] = request?.Source,
                ["sender"] = request?.Sender,
                ["q"] = request?.Q,
            },
        };

        return SendAsync<Inbound.ListInboundEmailsResponse>(_endpoints.ListInboundEmails, postaRequest, cancellationToken);
    }

    public Task<Inbound.DeleteAnInboundEmailResponse?> DeleteAnInboundEmailAsync(Inbound.DeleteAnInboundEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Inbound.DeleteAnInboundEmailResponse>(_endpoints.DeleteAnInboundEmail, postaRequest, cancellationToken);
    }

    public Task<Inbound.GetAnInboundEmailByUuidResponse?> GetAnInboundEmailByUuidAsync(Inbound.GetAnInboundEmailByUuidRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Inbound.GetAnInboundEmailByUuidResponse>(_endpoints.GetAnInboundEmailByUuid, postaRequest, cancellationToken);
    }

    public Task<Inbound.DownloadTheRawRfc5322MessageEmlResponse?> DownloadTheRawRfc5322MessageEmlAsync(Inbound.DownloadTheRawRfc5322MessageEmlRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Inbound.DownloadTheRawRfc5322MessageEmlResponse>(_endpoints.DownloadTheRawRfc5322MessageEml, postaRequest, cancellationToken);
    }

    public Task<Inbound.RetryWebhookDispatchForAFailedInboundEmailResponse?> RetryWebhookDispatchForAFailedInboundEmailAsync(Inbound.RetryWebhookDispatchForAFailedInboundEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Inbound.RetryWebhookDispatchForAFailedInboundEmailResponse>(_endpoints.RetryWebhookDispatchForAFailedInboundEmail, postaRequest, cancellationToken);
    }

    public Task<Inbound.DownloadAnInboundEmailAttachmentAuthenticatedResponse?> DownloadAnInboundEmailAttachmentAuthenticatedAsync(Inbound.DownloadAnInboundEmailAttachmentAuthenticatedRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["uuid"] = request?.Uuid,
                ["idx"] = request?.Idx,
            },
        };

        return SendAsync<Inbound.DownloadAnInboundEmailAttachmentAuthenticatedResponse>(_endpoints.DownloadAnInboundEmailAttachmentAuthenticated, postaRequest, cancellationToken);
    }

    public Task<Workspaces.ListPendingInvitationsResponse?> ListPendingInvitationsAsync(Workspaces.ListPendingInvitationsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ListPendingInvitationsResponse>(_endpoints.ListPendingInvitations, postaRequest, cancellationToken);
    }

    public Task<Workspaces.InviteMemberResponse?> InviteMemberAsync(Workspaces.InviteMemberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.InviteMemberResponse>(_endpoints.InviteMember, postaRequest, cancellationToken);
    }

    public Task<Workspaces.CancelInvitationResponse?> CancelInvitationAsync(Workspaces.CancelInvitationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["invitation_id"] = request?.InvitationId,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.CancelInvitationResponse>(_endpoints.CancelInvitation, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.ListLanguagesResponse?> ListLanguagesAsync(WorkspaceResources.ListLanguagesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<WorkspaceResources.ListLanguagesResponse>(_endpoints.ListLanguages, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.CreateLanguageResponse?> CreateLanguageAsync(WorkspaceResources.CreateLanguageRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.CreateLanguageResponse>(_endpoints.CreateLanguage, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.DeleteLanguageResponse?> DeleteLanguageAsync(WorkspaceResources.DeleteLanguageRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.DeleteLanguageResponse>(_endpoints.DeleteLanguage, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.UpdateLanguageResponse?> UpdateLanguageAsync(WorkspaceResources.UpdateLanguageRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.UpdateLanguageResponse>(_endpoints.UpdateLanguage, postaRequest, cancellationToken);
    }

    public Task<Templates.DeleteLocalizationResponse?> DeleteLocalizationAsync(Templates.DeleteLocalizationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["localizationId"] = request?.LocalizationId,
            },
        };

        return SendAsync<Templates.DeleteLocalizationResponse>(_endpoints.DeleteLocalization, postaRequest, cancellationToken);
    }

    public Task<Templates.UpdateLocalizationResponse?> UpdateLocalizationAsync(Templates.UpdateLocalizationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["localizationId"] = request?.LocalizationId,
            },
        };

        return SendAsync<Templates.UpdateLocalizationResponse>(_endpoints.UpdateLocalization, postaRequest, cancellationToken);
    }

    public Task<Workspaces.ListWorkspaceMembersResponse?> ListWorkspaceMembersAsync(Workspaces.ListWorkspaceMembersRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.ListWorkspaceMembersResponse>(_endpoints.ListWorkspaceMembers, postaRequest, cancellationToken);
    }

    public Task<Workspaces.RemoveMemberResponse?> RemoveMemberAsync(Workspaces.RemoveMemberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["member_id"] = request?.MemberId,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.RemoveMemberResponse>(_endpoints.RemoveMember, postaRequest, cancellationToken);
    }

    public Task<Workspaces.UpdateMemberRoleResponse?> UpdateMemberRoleAsync(Workspaces.UpdateMemberRoleRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["member_id"] = request?.MemberId,
            },
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.UpdateMemberRoleResponse>(_endpoints.UpdateMemberRole, postaRequest, cancellationToken);
    }

    public Task<Workspaces.GetWorkspacePlanWorkspacesResponse?> GetWorkspacePlanWorkspacesAsync(Workspaces.GetWorkspacePlanWorkspacesRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetWorkspacePlanWorkspacesResponse>(_endpoints.GetWorkspacePlanWorkspaces, postaRequest, cancellationToken);
    }

    public Task<Workspaces.GetWorkspaceSettingsResponse?> GetWorkspaceSettingsAsync(Workspaces.GetWorkspaceSettingsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetWorkspaceSettingsResponse>(_endpoints.GetWorkspaceSettings, postaRequest, cancellationToken);
    }

    public Task<Workspaces.UpdateWorkspaceSettingsResponse?> UpdateWorkspaceSettingsAsync(Workspaces.UpdateWorkspaceSettingsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.UpdateWorkspaceSettingsResponse>(_endpoints.UpdateWorkspaceSettings, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.ListSmtpServersResponse?> ListSmtpServersAsync(WorkspaceResources.ListSmtpServersRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<WorkspaceResources.ListSmtpServersResponse>(_endpoints.ListSmtpServers, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.AddSmtpServerResponse?> AddSmtpServerAsync(WorkspaceResources.AddSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.AddSmtpServerResponse>(_endpoints.AddSmtpServer, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.DeleteSmtpServerResponse?> DeleteSmtpServerAsync(WorkspaceResources.DeleteSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.DeleteSmtpServerResponse>(_endpoints.DeleteSmtpServer, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.GetSmtpServerResponse?> GetSmtpServerAsync(WorkspaceResources.GetSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.GetSmtpServerResponse>(_endpoints.GetSmtpServer, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.UpdateSmtpServerResponse?> UpdateSmtpServerAsync(WorkspaceResources.UpdateSmtpServerRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.UpdateSmtpServerResponse>(_endpoints.UpdateSmtpServer, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.TestSmtpServerConnectionResponse?> TestSmtpServerConnectionAsync(WorkspaceResources.TestSmtpServerConnectionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<WorkspaceResources.TestSmtpServerConnectionResponse>(_endpoints.TestSmtpServerConnection, postaRequest, cancellationToken);
    }

    public Task<Workspaces.DeleteWorkspaceSsoConfigResponse?> DeleteWorkspaceSsoConfigAsync(Workspaces.DeleteWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.DeleteWorkspaceSsoConfigResponse>(_endpoints.DeleteWorkspaceSsoConfig, postaRequest, cancellationToken);
    }

    public Task<Workspaces.GetWorkspaceSsoConfigResponse?> GetWorkspaceSsoConfigAsync(Workspaces.GetWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.GetWorkspaceSsoConfigResponse>(_endpoints.GetWorkspaceSsoConfig, postaRequest, cancellationToken);
    }

    public Task<Workspaces.SetWorkspaceSsoConfigResponse?> SetWorkspaceSsoConfigAsync(Workspaces.SetWorkspaceSsoConfigRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            Headers = new Dictionary<string, string>
            {
                ["X-Posta-Workspace-Id"] = Convert.ToString(request?.XPostaWorkspaceId, global::System.Globalization.CultureInfo.InvariantCulture) ?? string.Empty,
            },
        };

        return SendAsync<Workspaces.SetWorkspaceSsoConfigResponse>(_endpoints.SetWorkspaceSsoConfig, postaRequest, cancellationToken);
    }

    public Task<Templates.ListStylesheetsResponse?> ListStylesheetsAsync(Templates.ListStylesheetsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<Templates.ListStylesheetsResponse>(_endpoints.ListStylesheets, postaRequest, cancellationToken);
    }

    public Task<Templates.CreateStylesheetResponse?> CreateStylesheetAsync(Templates.CreateStylesheetRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Templates.CreateStylesheetResponse>(_endpoints.CreateStylesheet, postaRequest, cancellationToken);
    }

    public Task<Templates.DeleteStylesheetResponse?> DeleteStylesheetAsync(Templates.DeleteStylesheetRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.DeleteStylesheetResponse>(_endpoints.DeleteStylesheet, postaRequest, cancellationToken);
    }

    public Task<Templates.UpdateStylesheetResponse?> UpdateStylesheetAsync(Templates.UpdateStylesheetRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.UpdateStylesheetResponse>(_endpoints.UpdateStylesheet, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.ListSubscriberListsResponse?> ListSubscriberListsAsync(SubscriberLists.ListSubscriberListsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<SubscriberLists.ListSubscriberListsResponse>(_endpoints.ListSubscriberLists, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.CreateSubscriberListResponse?> CreateSubscriberListAsync(SubscriberLists.CreateSubscriberListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<SubscriberLists.CreateSubscriberListResponse>(_endpoints.CreateSubscriberList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.PreviewSegmentCountResponse?> PreviewSegmentCountAsync(SubscriberLists.PreviewSegmentCountRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<SubscriberLists.PreviewSegmentCountResponse>(_endpoints.PreviewSegmentCount, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.DeleteSubscriberListResponse?> DeleteSubscriberListAsync(SubscriberLists.DeleteSubscriberListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.DeleteSubscriberListResponse>(_endpoints.DeleteSubscriberList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.GetSubscriberListResponse?> GetSubscriberListAsync(SubscriberLists.GetSubscriberListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.GetSubscriberListResponse>(_endpoints.GetSubscriberList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.UpdateSubscriberListResponse?> UpdateSubscriberListAsync(SubscriberLists.UpdateSubscriberListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.UpdateSubscriberListResponse>(_endpoints.UpdateSubscriberList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.RemoveSubscriberFromListResponse?> RemoveSubscriberFromListAsync(SubscriberLists.RemoveSubscriberFromListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.RemoveSubscriberFromListResponse>(_endpoints.RemoveSubscriberFromList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.ListMembersOfSubscriberListResponse?> ListMembersOfSubscriberListAsync(SubscriberLists.ListMembersOfSubscriberListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<SubscriberLists.ListMembersOfSubscriberListResponse>(_endpoints.ListMembersOfSubscriberList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.AddSubscriberToListResponse?> AddSubscriberToListAsync(SubscriberLists.AddSubscriberToListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.AddSubscriberToListResponse>(_endpoints.AddSubscriberToList, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.ReSubscribeAnEmailToAListSubscriberListsResponse?> ReSubscribeAnEmailToAListSubscriberListsAsync(SubscriberLists.ReSubscribeAnEmailToAListSubscriberListsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.ReSubscribeAnEmailToAListSubscriberListsResponse>(_endpoints.ReSubscribeAnEmailToAListSubscriberLists, postaRequest, cancellationToken);
    }

    public Task<SubscriberLists.UnsubscribeAnEmailFromAListSubscriberListsResponse?> UnsubscribeAnEmailFromAListSubscriberListsAsync(SubscriberLists.UnsubscribeAnEmailFromAListSubscriberListsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<SubscriberLists.UnsubscribeAnEmailFromAListSubscriberListsResponse>(_endpoints.UnsubscribeAnEmailFromAListSubscriberLists, postaRequest, cancellationToken);
    }

    public Task<Subscribers.ListSubscribersResponse?> ListSubscribersAsync(Subscribers.ListSubscribersRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
                ["status"] = request?.Status,
            },
        };

        return SendAsync<Subscribers.ListSubscribersResponse>(_endpoints.ListSubscribers, postaRequest, cancellationToken);
    }

    public Task<Subscribers.CreateSubscriberResponse?> CreateSubscriberAsync(Subscribers.CreateSubscriberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Subscribers.CreateSubscriberResponse>(_endpoints.CreateSubscriber, postaRequest, cancellationToken);
    }

    public Task<Subscribers.BulkImportSubscribersCsvResponse?> BulkImportSubscribersCsvAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Subscribers.BulkImportSubscribersCsvResponse>(_endpoints.BulkImportSubscribersCsv, null, cancellationToken);
    }

    public Task<Subscribers.BulkImportSubscribersJsonResponse?> BulkImportSubscribersJsonAsync(Subscribers.BulkImportSubscribersJsonRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Subscribers.BulkImportSubscribersJsonResponse>(_endpoints.BulkImportSubscribersJson, postaRequest, cancellationToken);
    }

    public Task<Subscribers.DeleteSubscriberResponse?> DeleteSubscriberAsync(Subscribers.DeleteSubscriberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Subscribers.DeleteSubscriberResponse>(_endpoints.DeleteSubscriber, postaRequest, cancellationToken);
    }

    public Task<Subscribers.GetSubscriberResponse?> GetSubscriberAsync(Subscribers.GetSubscriberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Subscribers.GetSubscriberResponse>(_endpoints.GetSubscriber, postaRequest, cancellationToken);
    }

    public Task<Subscribers.UpdateSubscriberResponse?> UpdateSubscriberAsync(Subscribers.UpdateSubscriberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Subscribers.UpdateSubscriberResponse>(_endpoints.UpdateSubscriber, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.RemoveFromSuppressionListResponse?> RemoveFromSuppressionListAsync(WorkspaceResources.RemoveFromSuppressionListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.RemoveFromSuppressionListResponse>(_endpoints.RemoveFromSuppressionList, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.ListSuppressedEmailsResponse?> ListSuppressedEmailsAsync(WorkspaceResources.ListSuppressedEmailsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["list_id"] = request?.ListId,
            },
        };

        return SendAsync<WorkspaceResources.ListSuppressedEmailsResponse>(_endpoints.ListSuppressedEmails, postaRequest, cancellationToken);
    }

    public Task<WorkspaceResources.AddToSuppressionListResponse?> AddToSuppressionListAsync(WorkspaceResources.AddToSuppressionListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<WorkspaceResources.AddToSuppressionListResponse>(_endpoints.AddToSuppressionList, postaRequest, cancellationToken);
    }

    public Task<Templates.ListTemplatesResponse?> ListTemplatesAsync(Templates.ListTemplatesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["search"] = request?.Search,
            },
        };

        return SendAsync<Templates.ListTemplatesResponse>(_endpoints.ListTemplates, postaRequest, cancellationToken);
    }

    public Task<Templates.CreateTemplateResponse?> CreateTemplateAsync(Templates.CreateTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Templates.CreateTemplateResponse>(_endpoints.CreateTemplate, postaRequest, cancellationToken);
    }

    public Task<Templates.ImportTemplateResponse?> ImportTemplateAsync(Templates.ImportTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Templates.ImportTemplateResponse>(_endpoints.ImportTemplate, postaRequest, cancellationToken);
    }

    public Task<Templates.ImportHtmlTemplateResponse?> ImportHtmlTemplateAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Templates.ImportHtmlTemplateResponse>(_endpoints.ImportHtmlTemplate, null, cancellationToken);
    }

    public Task<Templates.PreviewTemplateResponse?> PreviewTemplateAsync(Templates.PreviewTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Templates.PreviewTemplateResponse>(_endpoints.PreviewTemplate, postaRequest, cancellationToken);
    }

    public Task<Templates.DeleteTemplateResponse?> DeleteTemplateAsync(Templates.DeleteTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.DeleteTemplateResponse>(_endpoints.DeleteTemplate, postaRequest, cancellationToken);
    }

    public Task<Templates.GetTemplateResponse?> GetTemplateAsync(Templates.GetTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.GetTemplateResponse>(_endpoints.GetTemplate, postaRequest, cancellationToken);
    }

    public Task<Templates.UpdateTemplateResponse?> UpdateTemplateAsync(Templates.UpdateTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.UpdateTemplateResponse>(_endpoints.UpdateTemplate, postaRequest, cancellationToken);
    }

    public Task<Templates.ActivateTemplateVersionResponse?> ActivateTemplateVersionAsync(Templates.ActivateTemplateVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.ActivateTemplateVersionResponse>(_endpoints.ActivateTemplateVersion, postaRequest, cancellationToken);
    }

    public Task<Templates.ExportTemplateResponse?> ExportTemplateAsync(Templates.ExportTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.ExportTemplateResponse>(_endpoints.ExportTemplate, postaRequest, cancellationToken);
    }

    public Task<Templates.SendTestEmailResponse?> SendTestEmailAsync(Templates.SendTestEmailRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.SendTestEmailResponse>(_endpoints.SendTestEmail, postaRequest, cancellationToken);
    }

    public Task<Templates.ListTemplateVersionsResponse?> ListTemplateVersionsAsync(Templates.ListTemplateVersionsRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.ListTemplateVersionsResponse>(_endpoints.ListTemplateVersions, postaRequest, cancellationToken);
    }

    public Task<Templates.CreateTemplateVersionResponse?> CreateTemplateVersionAsync(Templates.CreateTemplateVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Templates.CreateTemplateVersionResponse>(_endpoints.CreateTemplateVersion, postaRequest, cancellationToken);
    }

    public Task<Templates.DeleteTemplateVersionResponse?> DeleteTemplateVersionAsync(Templates.DeleteTemplateVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.DeleteTemplateVersionResponse>(_endpoints.DeleteTemplateVersion, postaRequest, cancellationToken);
    }

    public Task<Templates.UpdateTemplateVersionResponse?> UpdateTemplateVersionAsync(Templates.UpdateTemplateVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.UpdateTemplateVersionResponse>(_endpoints.UpdateTemplateVersion, postaRequest, cancellationToken);
    }

    public Task<Templates.ListLocalizationsForAVersionResponse?> ListLocalizationsForAVersionAsync(Templates.ListLocalizationsForAVersionRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.ListLocalizationsForAVersionResponse>(_endpoints.ListLocalizationsForAVersion, postaRequest, cancellationToken);
    }

    public Task<Templates.CreateLocalizationResponse?> CreateLocalizationAsync(Templates.CreateLocalizationRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.CreateLocalizationResponse>(_endpoints.CreateLocalization, postaRequest, cancellationToken);
    }

    public Task<Templates.PreviewLocalizedTemplateResponse?> PreviewLocalizedTemplateAsync(Templates.PreviewLocalizedTemplateRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
                ["versionId"] = request?.VersionId,
            },
        };

        return SendAsync<Templates.PreviewLocalizedTemplateResponse>(_endpoints.PreviewLocalizedTemplate, postaRequest, cancellationToken);
    }

    public Task<UnsubscribeLists.ListUnsubscribeListsResponse?> ListUnsubscribeListsAsync(UnsubscribeLists.ListUnsubscribeListsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<UnsubscribeLists.ListUnsubscribeListsResponse>(_endpoints.ListUnsubscribeLists, postaRequest, cancellationToken);
    }

    public Task<UnsubscribeLists.CreateUnsubscribeListResponse?> CreateUnsubscribeListAsync(UnsubscribeLists.CreateUnsubscribeListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<UnsubscribeLists.CreateUnsubscribeListResponse>(_endpoints.CreateUnsubscribeList, postaRequest, cancellationToken);
    }

    public Task<UnsubscribeLists.DeleteUnsubscribeListResponse?> DeleteUnsubscribeListAsync(UnsubscribeLists.DeleteUnsubscribeListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<UnsubscribeLists.DeleteUnsubscribeListResponse>(_endpoints.DeleteUnsubscribeList, postaRequest, cancellationToken);
    }

    public Task<UnsubscribeLists.GetUnsubscribeListResponse?> GetUnsubscribeListAsync(UnsubscribeLists.GetUnsubscribeListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<UnsubscribeLists.GetUnsubscribeListResponse>(_endpoints.GetUnsubscribeList, postaRequest, cancellationToken);
    }

    public Task<UnsubscribeLists.UpdateUnsubscribeListResponse?> UpdateUnsubscribeListAsync(UnsubscribeLists.UpdateUnsubscribeListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<UnsubscribeLists.UpdateUnsubscribeListResponse>(_endpoints.UpdateUnsubscribeList, postaRequest, cancellationToken);
    }

    public Task<Webhooks.ListWebhookDeliveriesWorkspaceResourcesResponse?> ListWebhookDeliveriesWorkspaceResourcesAsync(Webhooks.ListWebhookDeliveriesWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<Webhooks.ListWebhookDeliveriesWorkspaceResourcesResponse>(_endpoints.ListWebhookDeliveriesWorkspaceResources, postaRequest, cancellationToken);
    }

    public Task<Webhooks.ListWebhooksWorkspaceResourcesResponse?> ListWebhooksWorkspaceResourcesAsync(Webhooks.ListWebhooksWorkspaceResourcesRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
            },
        };

        return SendAsync<Webhooks.ListWebhooksWorkspaceResourcesResponse>(_endpoints.ListWebhooksWorkspaceResources, postaRequest, cancellationToken);
    }

    public Task<Webhooks.CreateWebhookUserResponse?> CreateWebhookUserAsync(Webhooks.CreateWebhookUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Webhooks.CreateWebhookUserResponse>(_endpoints.CreateWebhookUser, postaRequest, cancellationToken);
    }

    public Task<Webhooks.DeleteWebhookUserResponse?> DeleteWebhookUserAsync(Webhooks.DeleteWebhookUserRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            PathParameters = new Dictionary<string, object?>
            {
                ["id"] = request?.Id,
            },
        };

        return SendAsync<Webhooks.DeleteWebhookUserResponse>(_endpoints.DeleteWebhookUser, postaRequest, cancellationToken);
    }

    public Task<Health.LivenessProbeResponse?> LivenessProbeAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Health.LivenessProbeResponse>(_endpoints.LivenessProbe, null, cancellationToken);
    }

    public Task<Health.ReadinessProbeResponse?> ReadinessProbeAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Health.ReadinessProbeResponse>(_endpoints.ReadinessProbe, null, cancellationToken);
    }

}
