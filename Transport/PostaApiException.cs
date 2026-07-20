using System.Net;
using System.Text.Json.Serialization;

namespace Posta.Transport;

/// <summary>Represents a non-successful response returned by Posta.</summary>
public sealed class PostaApiException : HttpRequestException
{
    internal PostaApiException(
        HttpStatusCode statusCode,
        string? responseBody,
        PostaApiError? error,
        string message)
        : base(message, null, statusCode)
    {
        ResponseBody = responseBody;
        Error = error;
    }

    /// <summary>Gets the response body, when one was returned.</summary>
    public string? ResponseBody { get; }

    /// <summary>Gets the structured error returned by Posta, when the body matches the documented error response.</summary>
    public PostaApiError? Error { get; }
}

/// <summary>Structured details from a Posta error response.</summary>
public sealed class PostaApiError
{
    /// <summary>Gets the machine-readable error code.</summary>
    public string? Code { get; init; }

    /// <summary>Gets the error type.</summary>
    [JsonPropertyName("error")]
    public string? Type { get; init; }

    /// <summary>Gets the human-readable error message.</summary>
    public string? Message { get; init; }
}
