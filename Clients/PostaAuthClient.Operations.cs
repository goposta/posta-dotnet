using Posta.Transport;
using Auth = Posta.Models.Auth;

namespace Posta.Clients;

public sealed partial class PostaAuthClient
{
    public Task<Auth.RegistrationStatusResponse?> RegistrationStatusAsync(CancellationToken cancellationToken = default)
    {
        return SendAsync<Auth.RegistrationStatusResponse>(_endpoints.RegistrationStatus, null, cancellationToken);
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
    public Task<Auth.RegisterResponse?> RegisterAsync(Auth.RegisterRequest request, CancellationToken cancellationToken = default)
    {
        PostaRequest postaRequest = new()
        {
            Body = request,
        };

        return SendAsync<Auth.RegisterResponse>(_endpoints.Register, postaRequest, cancellationToken);
    }
}




