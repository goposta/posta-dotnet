using Posta.Transport;
using Subscribers = Posta.Models.Subscribers;

namespace Posta.Clients;

public sealed partial class PostaSubscribersClient
{
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
    public Task<Subscribers.CreateSubscriberResponse?> CreateSubscriberAsync(Subscribers.CreateSubscriberRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Subscribers.CreateSubscriberResponse>(_endpoints.CreateSubscriber, postaRequest, cancellationToken);
    }
    public Task<Subscribers.BulkImportSubscribersJsonResponse?> BulkImportSubscribersJsonAsync(Subscribers.BulkImportSubscribersJsonRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Subscribers.BulkImportSubscribersJsonResponse>(_endpoints.BulkImportSubscribersJson, postaRequest, cancellationToken);
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
    public Task<Subscribers.BulkImportSubscribersCsvResponse?> BulkImportSubscribersCsvAsync(Subscribers.BulkImportSubscribersCsvRequest request, CancellationToken cancellationToken = default)
    {
        ArgumentNullException.ThrowIfNull(request);
        var content = new MultipartFormDataContent();
        content.Add(new ByteArrayContent(request.File), "file", request.FileName);
        if (request.ColumnMapping is not null)
        {
            content.Add(new StringContent(System.Text.Json.JsonSerializer.Serialize(request.ColumnMapping)), "column_mapping");
        }

        return SendAsync<Subscribers.BulkImportSubscribersCsvResponse>(_endpoints.BulkImportSubscribersCsv, new PostaRequest { Content = content }, cancellationToken);
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
}




