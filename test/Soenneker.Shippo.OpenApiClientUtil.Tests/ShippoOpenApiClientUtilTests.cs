using Soenneker.Shippo.OpenApiClientUtil.Abstract;
using Soenneker.Tests.HostedUnit;

namespace Soenneker.Shippo.OpenApiClientUtil.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ShippoOpenApiClientUtilTests : HostedUnitTest
{
    private readonly IShippoOpenApiClientUtil _openapiclientutil;

    public ShippoOpenApiClientUtilTests(Host host) : base(host)
    {
        _openapiclientutil = Resolve<IShippoOpenApiClientUtil>(true);
    }

    [Test]
    public void Default()
    {

    }
}
