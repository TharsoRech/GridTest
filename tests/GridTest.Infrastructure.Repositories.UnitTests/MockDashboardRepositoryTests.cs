using Xunit;
using GridTest.Infrastructure.Repositories;
using GridTest.Domain.Interfaces;

namespace GridTest.Infrastructure.Repositories.UnitTests;

public class MockDashboardRepositoryTests
{
    [Fact]
    public async Task GetDashboardDataAsync_ReturnsCorrectData()
    {
        // Arrange
        IDashboardRepository repository = new MockDashboardRepository();

        // Act
        var metrics = await repository.GetDashboardDataAsync();

        // Assert
        Assert.NotNull(metrics);
        Assert.Equal(3468.96m, metrics.TotalEarnings);
        Assert.Equal(82, metrics.TotalSales);
        Assert.NotEmpty(metrics.RecentActivities);
        Assert.NotEmpty(metrics.Orders);
        Assert.NotEmpty(metrics.CardMetrics);
        Assert.NotEmpty(metrics.EarningsChartData);
        Assert.NotEmpty(metrics.SalesChartData);
        Assert.NotEmpty(metrics.TrafficData);
    }

    [Fact]
    public async Task GetDashboardDataAsync_ReturnsCorrectOrderCount()
    {
        // Arrange
        IDashboardRepository repository = new MockDashboardRepository();

        // Act
        var metrics = await repository.GetDashboardDataAsync();

        // Assert
        Assert.Equal(5, metrics.Orders.Count);
        Assert.Equal(5, metrics.RecentActivities.Count);
        Assert.Equal(4, metrics.CardMetrics.Count);
    }
}
