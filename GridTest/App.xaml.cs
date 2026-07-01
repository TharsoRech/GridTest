namespace GridTest;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        var window = new Window(new AppShell());
        
        // Set minimum window size for desktop platforms
#if MACCATALYST || WINDOWS
        window.Width = 1280;
        window.Height = 800;
#endif
        
        return window;
    }
}
