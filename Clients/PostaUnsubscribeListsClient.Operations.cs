using Posta.Transport;
using UnsubscribeLists = Posta.Models.UnsubscribeLists;

namespace Posta.Clients;

public sealed partial class PostaUnsubscribeListsClient
{
    public Task<UnsubscribeLists.ListUnsubscribeListsResponse?> ListUnsubscribeListsAsync(UnsubscribeLists.ListUnsubscribeListsRequest? request = null, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Query = new Dictionary<string, object?>
            {
                ["page"] = request?.Page,
                ["size"] = request?.Size,
                ["q"] = request?.Q,
                ["sort"] = request?.Sort,
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
}




