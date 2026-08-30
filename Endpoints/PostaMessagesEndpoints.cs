namespace Posta.Endpoints;

/// <summary>Endpoint definitions for Posta forms, message filters, and inbound messages.</summary>
public interface IPostaMessagesEndpoints
{
    PostaEndpoint SubmitForm { get; }
    PostaEndpoint GetFormNonce { get; }
    PostaEndpoint ListForms { get; }
    PostaEndpoint CreateForm { get; }
    PostaEndpoint GetForm { get; }
    PostaEndpoint UpdateForm { get; }
    PostaEndpoint DeleteForm { get; }
    PostaEndpoint RotateFormKey { get; }
    PostaEndpoint GetFormSnippet { get; }
    PostaEndpoint ListMessageFilters { get; }
    PostaEndpoint CreateMessageFilter { get; }
    PostaEndpoint UpdateMessageFilter { get; }
    PostaEndpoint DeleteMessageFilter { get; }
    PostaEndpoint TestMessageFilter { get; }
    PostaEndpoint ListMessages { get; }
    PostaEndpoint GetMessage { get; }
    PostaEndpoint DeleteMessage { get; }
    PostaEndpoint GetMessageAnalytics { get; }
    PostaEndpoint GetMessageStats { get; }
    PostaEndpoint AssignMessage { get; }
    PostaEndpoint GetMessageAttachment { get; }
    PostaEndpoint MarkMessageAsSpam { get; }
    PostaEndpoint MarkMessageAsNotSpam { get; }
    PostaEndpoint ReplyToMessage { get; }
    PostaEndpoint UpdateMessageState { get; }
}

public partial class PostaEndpoints
{
    public virtual PostaEndpoint SubmitForm { get; } = new(HttpMethod.Post, "/api/v1/f/{key}", PostaAuthentication.None);
    public virtual PostaEndpoint GetFormNonce { get; } = new(HttpMethod.Get, "/api/v1/f/{key}/nonce", PostaAuthentication.None);
    public virtual PostaEndpoint ListForms { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/forms", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint CreateForm { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/forms", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint GetForm { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/forms/{id}", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint UpdateForm { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/forms/{id}", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint DeleteForm { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/forms/{id}", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint RotateFormKey { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/forms/{id}/rotate-key", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint GetFormSnippet { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/forms/{id}/snippet", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint ListMessageFilters { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/message-filters", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint CreateMessageFilter { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/message-filters", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint UpdateMessageFilter { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/message-filters/{id}", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint DeleteMessageFilter { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/message-filters/{id}", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint TestMessageFilter { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/message-filters/test", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint ListMessages { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/messages", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint GetMessage { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/messages/{id}", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint DeleteMessage { get; } = new(HttpMethod.Delete, "/api/v1/workspaces/current/messages/{id}", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint GetMessageAnalytics { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/messages/analytics", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint GetMessageStats { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/messages/stats", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint AssignMessage { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/messages/{id}/assign", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint GetMessageAttachment { get; } = new(HttpMethod.Get, "/api/v1/workspaces/current/messages/{id}/attachments/{idx}", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint MarkMessageAsSpam { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/messages/{id}/spam", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint MarkMessageAsNotSpam { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/messages/{id}/not-spam", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint ReplyToMessage { get; } = new(HttpMethod.Post, "/api/v1/workspaces/current/messages/{id}/reply", PostaAuthentication.AccessToken);
    public virtual PostaEndpoint UpdateMessageState { get; } = new(HttpMethod.Put, "/api/v1/workspaces/current/messages/{id}/state", PostaAuthentication.AccessToken);
}
