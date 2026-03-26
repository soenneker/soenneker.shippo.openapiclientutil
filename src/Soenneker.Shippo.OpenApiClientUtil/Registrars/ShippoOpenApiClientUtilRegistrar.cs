using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Soenneker.Shippo.HttpClients.Registrars;
using Soenneker.Shippo.OpenApiClientUtil.Abstract;

namespace Soenneker.Shippo.OpenApiClientUtil.Registrars;

/// <summary>
/// Registers the OpenAPI client utility for dependency injection.
/// </summary>
public static class ShippoOpenApiClientUtilRegistrar
{
    /// <summary>
    /// Adds <see cref="ShippoOpenApiClientUtil"/> as a singleton service. <para/>
    /// </summary>
    public static IServiceCollection AddShippoOpenApiClientUtilAsSingleton(this IServiceCollection services)
    {
        services.AddShippoOpenApiHttpClientAsSingleton()
                .TryAddSingleton<IShippoOpenApiClientUtil, ShippoOpenApiClientUtil>();

        return services;
    }

    /// <summary>
    /// Adds <see cref="ShippoOpenApiClientUtil"/> as a scoped service. <para/>
    /// </summary>
    public static IServiceCollection AddShippoOpenApiClientUtilAsScoped(this IServiceCollection services)
    {
        services.AddShippoOpenApiHttpClientAsSingleton()
                .TryAddScoped<IShippoOpenApiClientUtil, ShippoOpenApiClientUtil>();

        return services;
    }
}
