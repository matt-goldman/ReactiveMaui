using ReactiveMaui.ViewModels;

namespace ReactiveMaui;

public partial class AppShell : Shell
{
    private readonly ShellViewModel _viewModel;

    public AppShell(ShellViewModel viewModel)
    {
        _viewModel = viewModel;
        BindingContext = _viewModel;
        InitializeComponent();
    }
}
