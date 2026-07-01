using Xunit;
using Microsoft.Extensions.DependencyInjection;
using GridTest.Infrastructure;
using GridTest.Infrastructure.Repositories;
using GridTest.Domain.Interfaces;

namespace GridTest.Infrastructure.UnitTests;

public class DependencyInjectionTests
{
    [Fact]
    public void AddInfrastructure_ReturnsServiceCollection()
    {
        // Arrange
        var services = new ServiceCollection();

        // Act
        var result = services.AddInfrastructure();

        // Assert
        Assert.NotNull(result);
        Assert.IsType<ServiceCollection>(result);
    }
}
