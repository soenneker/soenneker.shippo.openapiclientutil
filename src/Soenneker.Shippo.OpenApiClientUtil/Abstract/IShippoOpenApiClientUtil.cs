using Soenneker.Shippo.OpenApiClient;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Shippo.OpenApiClientUtil.Abstract;

/// <summary>
/// Exposes a cached OpenAPI client instance.
/// </summary>
public interface IShippoOpenApiClientUtil: IDisposable, IAsyncDisposable
{
    ValueTask<ShippoOpenApiClient> Get(CancellationToken cancellationToken = default);
}
