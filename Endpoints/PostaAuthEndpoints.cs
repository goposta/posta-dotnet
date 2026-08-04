namespace Posta.Endpoints;

/// <summary>Endpoint definitions for the Auth API area.</summary>
public interface IPostaAuthEndpoints
{
    /// <summary>Request password reset</summary>
        PostaEndpoint RequestPasswordReset { get; }

    /// <summary>Login</summary>
        PostaEndpoint Login { get; }

    /// <summary>Register</summary>
        PostaEndpoint Register { get; }

    /// <summary>Registration status</summary>
        PostaEndpoint RegistrationStatus { get; }

    /// <summary>Reset password</summary>
        PostaEndpoint ResetPassword { get; }

    /// <summary>Verify email address</summary>
        PostaEndpoint VerifyEmailAddress { get; }
}

public partial class PostaEndpoints
{
    /// <inheritdoc />
        public virtual PostaEndpoint RequestPasswordReset { get; } = new(HttpMethod.Post, "/api/v1/auth/forgot-password", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint Login { get; } = new(HttpMethod.Post, "/api/v1/auth/login", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint Register { get; } = new(HttpMethod.Post, "/api/v1/auth/register", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint RegistrationStatus { get; } = new(HttpMethod.Get, "/api/v1/auth/registration-status", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint ResetPassword { get; } = new(HttpMethod.Post, "/api/v1/auth/reset-password", PostaAuthentication.None);

    /// <inheritdoc />
        public virtual PostaEndpoint VerifyEmailAddress { get; } = new(HttpMethod.Get, "/api/v1/auth/verify-email", PostaAuthentication.None);
}
