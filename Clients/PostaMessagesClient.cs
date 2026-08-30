using Posta.Endpoints;
using Posta.Transport;
using System.Text.Json;

namespace Posta.Clients;

/// <summary>Provides access to forms, message filters, and inbound messages introduced in Posta 0.14.</summary>
/// <remarks>
/// The message feature's request and response schemas evolve independently of the email API.
/// These operations therefore return the API document directly while preserving the SDK's
/// standard authentication, path expansion, query handling, error handling, and streaming behavior.
/// </remarks>
public sealed class PostaMessagesClient : PostaSectionClient
{
    private readonly IPostaMessagesEndpoints _endpoints;

    internal PostaMessagesClient(PostaTransport transport, IPostaMessagesEndpoints endpoints)
        : base(transport) => _endpoints = endpoints;

    public Task<JsonDocument?> SubmitFormAsync(string key, object? body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.SubmitForm, WithPath("key", key, body), cancellationToken);
    public Task<JsonDocument?> GetFormNonceAsync(string key, CancellationToken cancellationToken = default) => SendAsync(_endpoints.GetFormNonce, WithPath("key", key), cancellationToken);
    public Task<JsonDocument?> ListFormsAsync(PostaRequest? request = null, CancellationToken cancellationToken = default) => SendAsync(_endpoints.ListForms, request, cancellationToken);
    public Task<JsonDocument?> CreateFormAsync(object body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.CreateForm, WithBody(body), cancellationToken);
    public Task<JsonDocument?> GetFormAsync(object id, CancellationToken cancellationToken = default) => SendAsync(_endpoints.GetForm, WithPath("id", id), cancellationToken);
    public Task<JsonDocument?> UpdateFormAsync(object id, object body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.UpdateForm, WithPath("id", id, body), cancellationToken);
    public Task<JsonDocument?> DeleteFormAsync(object id, CancellationToken cancellationToken = default) => SendAsync(_endpoints.DeleteForm, WithPath("id", id), cancellationToken);
    public Task<JsonDocument?> RotateFormKeyAsync(object id, CancellationToken cancellationToken = default) => SendAsync(_endpoints.RotateFormKey, WithPath("id", id), cancellationToken);
    public Task<JsonDocument?> GetFormSnippetAsync(object id, CancellationToken cancellationToken = default) => SendAsync(_endpoints.GetFormSnippet, WithPath("id", id), cancellationToken);
    public Task<JsonDocument?> ListMessageFiltersAsync(PostaRequest? request = null, CancellationToken cancellationToken = default) => SendAsync(_endpoints.ListMessageFilters, request, cancellationToken);
    public Task<JsonDocument?> CreateMessageFilterAsync(object body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.CreateMessageFilter, WithBody(body), cancellationToken);
    public Task<JsonDocument?> UpdateMessageFilterAsync(object id, object body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.UpdateMessageFilter, WithPath("id", id, body), cancellationToken);
    public Task<JsonDocument?> DeleteMessageFilterAsync(object id, CancellationToken cancellationToken = default) => SendAsync(_endpoints.DeleteMessageFilter, WithPath("id", id), cancellationToken);
    public Task<JsonDocument?> TestMessageFilterAsync(object body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.TestMessageFilter, WithBody(body), cancellationToken);
    public Task<JsonDocument?> ListMessagesAsync(PostaRequest? request = null, CancellationToken cancellationToken = default) => SendAsync(_endpoints.ListMessages, request, cancellationToken);
    public Task<JsonDocument?> GetMessageAsync(object id, CancellationToken cancellationToken = default) => SendAsync(_endpoints.GetMessage, WithPath("id", id), cancellationToken);
    public Task<JsonDocument?> DeleteMessageAsync(object id, CancellationToken cancellationToken = default) => SendAsync(_endpoints.DeleteMessage, WithPath("id", id), cancellationToken);
    public Task<JsonDocument?> GetMessageAnalyticsAsync(PostaRequest? request = null, CancellationToken cancellationToken = default) => SendAsync(_endpoints.GetMessageAnalytics, request, cancellationToken);
    public Task<JsonDocument?> GetMessageStatsAsync(CancellationToken cancellationToken = default) => SendAsync(_endpoints.GetMessageStats, null, cancellationToken);
    public Task<JsonDocument?> AssignMessageAsync(object id, object body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.AssignMessage, WithPath("id", id, body), cancellationToken);
    public Task<PostaStreamResponse> GetMessageAttachmentAsync(object id, object idx, CancellationToken cancellationToken = default) => SendStreamAsync(_endpoints.GetMessageAttachment, new PostaRequest { PathParameters = new Dictionary<string, object?> { ["id"] = id, ["idx"] = idx } }, cancellationToken);
    public Task<JsonDocument?> MarkMessageAsSpamAsync(object id, object? body = null, CancellationToken cancellationToken = default) => SendAsync(_endpoints.MarkMessageAsSpam, WithPath("id", id, body), cancellationToken);
    public Task<JsonDocument?> MarkMessageAsNotSpamAsync(object id, CancellationToken cancellationToken = default) => SendAsync(_endpoints.MarkMessageAsNotSpam, WithPath("id", id), cancellationToken);
    public Task<JsonDocument?> ReplyToMessageAsync(object id, object body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.ReplyToMessage, WithPath("id", id, body), cancellationToken);
    public Task<JsonDocument?> UpdateMessageStateAsync(object id, object body, CancellationToken cancellationToken = default) => SendAsync(_endpoints.UpdateMessageState, WithPath("id", id, body), cancellationToken);

    private static PostaRequest WithBody(object body) => new() { Body = body };
    private static PostaRequest WithPath(string name, object value, object? body = null) => new() { PathParameters = new Dictionary<string, object?> { [name] = value }, Body = body };
}
