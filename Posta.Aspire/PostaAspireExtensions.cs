using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Logging;
using Posta.Clients;
using Posta.Configuration;
using Posta.Endpoints;

#pragma warning disable IDE0130
namespace Microsoft.Extensions.Hosting;
#pragma warning restore IDE0130

/// <summary>Extension methods for registering the Posta SDK in an Aspire client project.</summary>
public static class PostaAspireExtensions
{
    private const string DefaultConfigurationSection = "Aspire:Posta:Client";

    /// <summary>Registers a default and keyed Posta client using Aspire service discovery.</summary>
    public static void AddPostaClient(
        this IHostApplicationBuilder builder,
        string connectionName,
        Action<PostaClientSettings>? configureSettings = null,
        string? configurationSectionName = null)
    {
        AddPostaClientCore(builder, connectionName, connectionName, registerDefault: true, configureSettings, configurationSectionName);
    }

    /// <summary>Registers a keyed Posta client whose service key is the connection name.</summary>
    public static void AddKeyedPostaClient(
        this IHostApplicationBuilder builder,
        string connectionName,
        Action<PostaClientSettings>? configureSettings = null,
        string? configurationSectionName = null)
    {
        AddPostaClientCore(builder, connectionName, connectionName, registerDefault: false, configureSettings, configurationSectionName);
    }

    /// <summary>Registers a keyed Posta client using a custom dependency-injection key.</summary>
    public static void AddKeyedPostaClient(
        this IHostApplicationBuilder builder,
        object serviceKey,
        string connectionName,
        Action<PostaClientSettings>? configureSettings = null,
        string? configurationSectionName = null)
    {
        ArgumentNullException.ThrowIfNull(serviceKey);
        AddPostaClientCore(builder, serviceKey, connectionName, registerDefault: false, configureSettings, configurationSectionName);
    }

    private static void AddPostaClientCore(
        IHostApplicationBuilder builder,
        object serviceKey,
        string connectionName,
        bool registerDefault,
        Action<PostaClientSettings>? configureSettings,
        string? configurationSectionName)
    {
        ArgumentNullException.ThrowIfNull(builder);
        ArgumentException.ThrowIfNullOrWhiteSpace(connectionName);

        PostaClientSettings settings = new();
        var sectionName = configurationSectionName ?? DefaultConfigurationSection;
        builder.Configuration.GetSection(sectionName).Bind(settings);
        builder.Configuration.GetSection($"{sectionName}:{connectionName}").Bind(settings);
        ApplyConnectionString(settings, builder.Configuration.GetConnectionString(connectionName));
        configureSettings?.Invoke(settings);

        var endpoint = settings.Endpoint ?? new Uri($"http://{connectionName}", UriKind.Absolute);
        builder.Services.AddHttpClient($"Posta:{connectionName}", client =>
        {
            client.BaseAddress = endpoint;
            client.Timeout = settings.Timeout;
        }).AddServiceDiscovery();

        builder.Services.TryAddSingleton<IPostaEndpoints, PostaEndpoints>();
        builder.Services.AddKeyedSingleton<PostaClient>(serviceKey, (services, _) =>
        {
            var credentialProvider =
                services.GetService<IPostaCredentialProvider>() ?? new SettingsCredentialProvider(settings);
            var httpClient = services.GetRequiredService<IHttpClientFactory>().CreateClient($"Posta:{connectionName}");
            return new PostaClient(
                httpClient,
                credentialProvider,
                services.GetRequiredService<IPostaEndpoints>(),
                services.GetRequiredService<ILoggerFactory>());
        });

        if (registerDefault)
        {
            builder.Services.TryAddSingleton(services => services.GetRequiredKeyedService<PostaClient>(serviceKey));
        }
    }

    private static void ApplyConnectionString(PostaClientSettings settings, string? connectionString)
    {
        if (string.IsNullOrWhiteSpace(connectionString))
        {
            return;
        }

        if (Uri.TryCreate(connectionString, UriKind.Absolute, out var uri))
        {
            settings.Endpoint = uri;
            return;
        }

        foreach (var part in connectionString.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries))
        {
            var separator = part.IndexOf('=');
            if (separator <= 0)
            {
                continue;
            }

            var name = part[..separator];
            var value = part[(separator + 1)..];
            if (name.Equals("Endpoint", StringComparison.OrdinalIgnoreCase) &&
                Uri.TryCreate(value, UriKind.Absolute, out uri))
            {
                settings.Endpoint = uri;
            }
            else if (name.Equals("ApiKey", StringComparison.OrdinalIgnoreCase))
            {
                settings.ApiKey = value;
            }
            else if (name.Equals("AccessToken", StringComparison.OrdinalIgnoreCase))
            {
                settings.AccessToken = value;
            }
        }
    }

    private sealed class SettingsCredentialProvider(PostaClientSettings settings) : IPostaCredentialProvider
    {
        public ValueTask<string?> GetCredentialAsync(
            PostaAuthentication authentication,
            CancellationToken cancellationToken = default)
        {
            cancellationToken.ThrowIfCancellationRequested();
            return ValueTask.FromResult(authentication switch
            {
                PostaAuthentication.None => null,
                PostaAuthentication.ApiKey => settings.ApiKey,
                PostaAuthentication.AccessToken => settings.AccessToken,
                _ => throw new ArgumentOutOfRangeException(nameof(authentication))
            });
        }
    }
}
