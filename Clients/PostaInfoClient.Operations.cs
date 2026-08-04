using Info = Posta.Models.Info;

namespace Posta.Clients;

public sealed partial class PostaInfoClient
{
    public Task<Info.ApplicationInfoResponse?> ApplicationInfoAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Info.ApplicationInfoResponse>(_endpoints.ApplicationInfo, null, cancellationToken);
    }
}




