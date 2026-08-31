[![](https://img.shields.io/nuget/v/soenneker.shippo.openapiclientutil.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.shippo.openapiclientutil/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.shippo.openapiclientutil/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.shippo.openapiclientutil/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.shippo.openapiclientutil.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.shippo.openapiclientutil/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.shippo.openapiclientutil/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.shippo.openapiclientutil/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Shippo.OpenApiClientUtil

Provides a lazily initialized Shippo client for shipments, rates, labels, tracking, addresses, parcels, customs, manifests, pickups, refunds, orders, and webhooks.

## Installation

```bash
dotnet add package Soenneker.Shippo.OpenApiClientUtil
```

## Configuration

```json
{
  "Shippo": {
    "ApiKey": "your-shippo-token"
  }
}
```

Set `Shippo:ClientBaseUrl` only when requests should use a different Shippo-compatible API origin. Authentication header overrides supported by the HTTP provider also apply here.

## Usage

```csharp
using Soenneker.Shippo.OpenApiClientUtil.Abstract;
using Soenneker.Shippo.OpenApiClientUtil.Registrars;

services.AddShippoOpenApiClientUtilAsSingleton();

public sealed class ShipmentReader
{
    private readonly IShippoOpenApiClientUtil _shippo;

    public ShipmentReader(IShippoOpenApiClientUtil shippo)
    {
        _shippo = shippo;
    }

    public async Task GetShipments(CancellationToken cancellationToken)
    {
        var client = await _shippo.Get(cancellationToken);
        var shipments = await client.Shipments.GetAsync(
            cancellationToken: cancellationToken);
    }
}
```

Use `AddShippoOpenApiClientUtilAsScoped()` when each scope should have its own generated client wrapper. Both registrations reuse the singleton authenticated HTTP client provider; disposing a scoped utility does not remove that provider's client.
