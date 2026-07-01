using Microsoft.Extensions.Logging;
using GridTest.Infrastructure;
using GridTest.ViewModels;

namespace GridTest;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

        // Register all Infrastructure services (repositories, HTTP clients, etc.)
        builder.Services.AddInfrastructure();

        // Register ViewModels
        builder.Services.AddTransient<MainPageViewModel>();

        // Register Pages
        builder.Services.AddTransient<MainPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
