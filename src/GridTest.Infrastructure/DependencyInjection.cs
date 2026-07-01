using Microsoft.Extensions.DependencyInjection;
using GridTest.Domain.Interfaces;
using GridTest.Infrastructure.Repositories;

namespace GridTest.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddSingleton<IDashboardRepository, MockDashboardRepository>();
        return services;
    }
}
