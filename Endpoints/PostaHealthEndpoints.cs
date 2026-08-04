namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Health API area.</summary>
public interface IPostaHealthEndpoints
{
    /// <summary>Liveness probe</summary>
        PostaEndpoint LivenessProbe { get; }

    /// <summary>Readiness probe</summary>
        PostaEndpoint ReadinessProbe { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint LivenessProbe { get; } = new(HttpMethod.Get, "/healthz", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint ReadinessProbe { get; } = new(HttpMethod.Get, "/readyz", PostaAuthentication.None);
}
