using Posta.Transport;
using SubscriberLists = Posta.Models.SubscriberLists;

namespace Posta.Clients;

public sealed partial class PostaSubscriberListsClient
{
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
    public Task<SubscriberLists.CreateSubscriberListResponse?> CreateSubscriberListAsync(SubscriberLists.CreateSubscriberListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<SubscriberLists.CreateSubscriberListResponse>(_endpoints.CreateSubscriberList, postaRequest, cancellationToken);
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
    public Task<SubscriberLists.ListSubscriberListsResponse?> ListSubscriberListsAsync(SubscriberLists.ListSubscriberListsRequest? request = null, CancellationToken cancellationToken = default)
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

        return SendAsync<SubscriberLists.ListSubscriberListsResponse>(_endpoints.ListSubscriberLists, postaRequest, cancellationToken);
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
    public Task<SubscriberLists.SubscribeAnEmailToAListResponse?> SubscribeAnEmailToAListAsync(SubscriberLists.SubscribeAnEmailToAListRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<SubscriberLists.SubscribeAnEmailToAListResponse>(_endpoints.SubscribeAnEmailToAList, postaRequest, cancellationToken);
    }
    public Task<SubscriberLists.PreviewSegmentCountResponse?> PreviewSegmentCountAsync(SubscriberLists.PreviewSegmentCountRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<SubscriberLists.PreviewSegmentCountResponse>(_endpoints.PreviewSegmentCount, postaRequest, cancellationToken);
    }
}




