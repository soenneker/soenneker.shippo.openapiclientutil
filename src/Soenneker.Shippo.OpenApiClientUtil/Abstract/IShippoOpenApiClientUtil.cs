using Soenneker.Shippo.OpenApiClient;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Soenneker.Shippo.OpenApiClientUtil.Abstract;

/// <summary>
/// Provides a lazily initialized Shippo API client.
/// </summary>
public interface IShippoOpenApiClientUtil : IDisposable, IAsyncDisposable
{
    /// <summary>
    /// Gets the shared client for this utility instance.
    /// </summary>
    /// <param name="cancellationToken">The cancellation token.</param>
    /// <returns>A task containing the result of the operation.</returns>
    ValueTask<ShippoOpenApiClient> Get(CancellationToken cancellationToken = default);

    /// <summary>
    /// Releases resources used by the current instance.
    /// </summary>
    new void Dispose();

    /// <summary>
    /// Asynchronously releases resources used by the current instance.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation.</returns>
    new ValueTask DisposeAsync();
}
