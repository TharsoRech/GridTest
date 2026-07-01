using CommunityToolkit.Mvvm.ComponentModel;

namespace GridTest.ViewModels;

public abstract partial class ViewModelBase : ObservableObject
{
    [ObservableProperty]
    private bool _isBusy;

    public virtual Task InitializeAsync()
    {
        return Task.CompletedTask;
    }
}
