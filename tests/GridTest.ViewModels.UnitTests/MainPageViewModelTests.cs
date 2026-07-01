using Xunit;
using GridTest.ViewModels;
using GridTest.Domain.Interfaces;
using GridTest.Domain.Entities;
using NSubstitute;

namespace GridTest.ViewModels.UnitTests;

public class MainPageViewModelTests
{
    [Fact]
    public async Task InitializeAsync_LoadsDashboardData()
    {
        // Arrange
        var mockRepo = Substitute.For<IDashboardRepository>();
        var expectedMetrics = new DashboardMetrics { TotalEarnings = 1000m, TotalSales = 50 };
        mockRepo.GetDashboardDataAsync().Returns(expectedMetrics);
        
        var viewModel = new MainPageViewModel(mockRepo);

        // Act
        await viewModel.InitializeAsync();

        // Assert
        Assert.Equal(expectedMetrics, viewModel.Metrics);
        Assert.False(viewModel.IsBusy);
    }

    [Fact]
    public async Task InitializeAsync_SetsIsBusyCorrectly()
    {
        // Arrange
        var mockRepo = Substitute.For<IDashboardRepository>();
        mockRepo.GetDashboardDataAsync().Returns(new DashboardMetrics());
        
        var viewModel = new MainPageViewModel(mockRepo);

        // Act & Assert
        Assert.False(viewModel.IsBusy);
        await viewModel.InitializeAsync();
        Assert.False(viewModel.IsBusy); // Should be false after completion
    }
}
