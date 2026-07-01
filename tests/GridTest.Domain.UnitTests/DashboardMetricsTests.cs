using Xunit;
using GridTest.Domain.Entities;

namespace GridTest.Domain.UnitTests;

public class DashboardMetricsTests
{
    [Fact]
    public void TotalEarningsFormatted_ReturnsCorrectFormat()
    {
        // Arrange
        var metrics = new DashboardMetrics { TotalEarnings = 3468.96m };

        // Act
        var result = metrics.TotalEarningsFormatted;

        // Assert
        Assert.Equal(3468.96m, metrics.TotalEarnings);
    }

    [Fact]
    public void DashboardMetrics_DefaultValues_AreCorrect()
    {
        // Arrange & Act
        var metrics = new DashboardMetrics();

        // Assert
        Assert.Equal(0m, metrics.TotalEarnings);
        Assert.Equal(0, metrics.TotalSales);
        Assert.NotNull(metrics.EarningsChartData);
        Assert.NotNull(metrics.SalesChartData);
        Assert.NotNull(metrics.TrafficData);
        Assert.NotNull(metrics.RecentActivities);
        Assert.NotNull(metrics.Orders);
        Assert.NotNull(metrics.CardMetrics);
    }
}
