using CommunityToolkit.Mvvm.ComponentModel;
using GridTest.Domain.Entities;
using GridTest.Domain.Interfaces;

namespace GridTest.ViewModels;

public partial class MainPageViewModel(IDashboardRepository dashboardRepository) : ViewModelBase
{

    [ObservableProperty]
    private DashboardMetrics _metrics = new DashboardMetrics();

    public override async Task InitializeAsync()
    {
        IsBusy = true;
        try
        {
            Metrics = await dashboardRepository.GetDashboardDataAsync();
        }
        finally
        {
            IsBusy = false;
        }
    }
}
