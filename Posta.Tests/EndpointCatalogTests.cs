using Posta.Endpoints;

namespace Posta.Tests;

public sealed class EndpointCatalogTests
{
    [Fact]
    public void AggregateEndpointCatalogContainsEveryApiAreaAndOperation()
    {
        var areas = typeof(IPostaEndpoints).GetInterfaces();
        var operationCount = areas.Sum(area => area.GetProperties().Length);

        Assert.Equal(16, areas.Length);
        Assert.Equal(226, operationCount);
        Assert.All(areas, area => Assert.EndsWith("Endpoints", area.Name, StringComparison.Ordinal));
    }

    [Fact]
    public void DefaultCatalogImplementsEachAreaCatalog()
    {
        Assert.All(
            typeof(IPostaEndpoints).GetInterfaces(),
            area => Assert.True(area.IsAssignableFrom(typeof(PostaEndpoints)), $"PostaEndpoints must implement {area.Name}."));
    }
}
