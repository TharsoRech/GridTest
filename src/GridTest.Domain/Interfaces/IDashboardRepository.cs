namespace GridTest.Domain.Interfaces;

public interface IDashboardRepository
{
    Task<Entities.DashboardMetrics> GetDashboardDataAsync();
}
