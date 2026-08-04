namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Info API area.</summary>
public interface IPostaInfoEndpoints
{
    /// <summary>Application info</summary>
        PostaEndpoint ApplicationInfo { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint ApplicationInfo { get; } = new(HttpMethod.Get, "/api/v1/info", PostaAuthentication.None);
}
