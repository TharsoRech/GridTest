namespace GridTest.Components;

public partial class HeaderView : ContentView
{
    public HeaderView()
    {
        InitializeComponent();
    }

    private async void OnMenuTapped(object? sender, TappedEventArgs e)
    {
        // Navigate up the visual tree to find the Shell
        var shell = Application.Current?.Windows.FirstOrDefault()?.Page as Shell;
        if (shell != null)
        {
            shell.FlyoutIsPresented = !shell.FlyoutIsPresented;
        }
    }
}
