using Soenneker.Shippo.OpenApiClientUtil.Abstract;
using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Shippo.OpenApiClientUtil.Tests;

[Collection("Collection")]
public sealed class ShippoOpenApiClientUtilTests : FixturedUnitTest
{
    private readonly IShippoOpenApiClientUtil _openapiclientutil;

    public ShippoOpenApiClientUtilTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
        _openapiclientutil = Resolve<IShippoOpenApiClientUtil>(true);
    }

    [Fact]
    public void Default()
    {

    }
}
