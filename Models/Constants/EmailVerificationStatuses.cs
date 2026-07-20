namespace Posta.Models.Constants;

/// <summary>Provides the possible email verification statuses.</summary>
public static class EmailVerificationStatuses
{
    /// <summary>The email address is valid.</summary>
    public const string Valid = "valid";

    /// <summary>The email address is invalid.</summary>
    public const string Invalid = "invalid";

    /// <summary>The email address may be risky to use.</summary>
    public const string Risky = "risky";

    /// <summary>The email address belongs to a disposable email provider.</summary>
    public const string Disposable = "disposable";

    /// <summary>The email address status could not be determined.</summary>
    public const string Unknown = "unknown";
}
