using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Shippo.HttpClients.Registrars;
using Soenneker.Shippo.OpenApiClientUtil.Abstract;

namespace Soenneker.Shippo.OpenApiClientUtil.Registrars;

/// <summary>
/// Registers the lazily initialized Shippo API client.
/// </summary>
public static class ShippoOpenApiClientUtilRegistrar
{
    /// <summary>
    /// Adds the Shippo API client utility as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddShippoOpenApiClientUtilAsSingleton(this IServiceCollection services)
    {
        services.AddShippoOpenApiHttpClientAsSingleton()
                .TryAddSingleton<IShippoOpenApiClientUtil, ShippoOpenApiClientUtil>();

        return services;
    }

    /// <summary>
    /// Adds the Shippo API client utility as a scoped service backed by the singleton HTTP client provider. <para/>
    /// </summary>
    public static IServiceCollection AddShippoOpenApiClientUtilAsScoped(this IServiceCollection services)
    {
        services.AddShippoOpenApiHttpClientAsSingleton()
                .TryAddScoped<IShippoOpenApiClientUtil, ShippoOpenApiClientUtil>();

        return services;
    }
}
