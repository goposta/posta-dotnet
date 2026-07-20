namespace Posta.Models.Constants;

/// <summary>Provides the supported API key scopes.</summary>
public static class ApiKeyScopes
{
    /// <summary>Grants permission to send email.</summary>
    public const string Send = "send";

    /// <summary>Grants read permission.</summary>
    public const string Read = "read";

    /// <summary>Grants permission to manage webhooks.</summary>
    public const string Webhooks = "webhooks";

    /// <summary>Grants all available permissions.</summary>
    public const string All = "*";
}
