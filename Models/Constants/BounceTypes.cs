namespace Posta.Models.Constants;

/// <summary>Provides the supported email bounce types.</summary>
public static class BounceTypes
{
    /// <summary>A permanent delivery failure.</summary>
    public const string Hard = "hard";

    /// <summary>A temporary delivery failure.</summary>
    public const string Soft = "soft";
}
