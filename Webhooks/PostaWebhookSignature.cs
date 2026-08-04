using System.Security.Cryptography;
using System.Text;

namespace Posta.Security;

/// <summary>Verifies signatures attached to Posta webhook requests.</summary>
public static class PostaWebhookSignature
{
    public const string HeaderName = "X-Posta-Signature";

    public static bool Verify(ReadOnlySpan<byte> body, string secret, string? signature)
    {
        ArgumentNullException.ThrowIfNull(secret);
        if (string.IsNullOrWhiteSpace(signature) || !signature.StartsWith("sha256=", StringComparison.Ordinal)) return false;

        byte[] supplied;
        try
        {
            supplied = Convert.FromHexString(signature[7..]);
        }
        catch (FormatException)
        {
            return false;
        }

        if (supplied.Length != 32) return false;

        Span<byte> expected = stackalloc byte[32];
        HMACSHA256.HashData(Encoding.UTF8.GetBytes(secret), body, expected);
        return CryptographicOperations.FixedTimeEquals(expected, supplied);
    }

    public static bool Verify(string body, string secret, string? signature) =>
        Verify(Encoding.UTF8.GetBytes(body ?? throw new ArgumentNullException(nameof(body))), secret, signature);
}
