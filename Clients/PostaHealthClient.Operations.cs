using Health = Posta.Models.Health;

namespace Posta.Clients;

public sealed partial class PostaHealthClient
{
    public Task<Health.LivenessProbeResponse?> LivenessProbeAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Health.LivenessProbeResponse>(_endpoints.LivenessProbe, null, cancellationToken);
    }
    public Task<Health.ReadinessProbeResponse?> ReadinessProbeAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Health.ReadinessProbeResponse>(_endpoints.ReadinessProbe, null, cancellationToken);
    }
}




