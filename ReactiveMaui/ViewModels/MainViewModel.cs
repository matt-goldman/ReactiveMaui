using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ReactiveMaui.Services;

namespace ReactiveMaui.ViewModels;

public partial class MainViewModel : ObservableObject
{
    private readonly ScoreService _scoreService;
    [ObservableProperty]
    private int _count = 0;

    [ObservableProperty]
    private string _buttonText = "Click me!";

    public MainViewModel(ScoreService scoreService)
    {
        _scoreService = scoreService;
    }

    [RelayCommand]
    private void IncrementCount()
    {
        Count++;

        if (Count == 1)
            ButtonText = $"Clicked {Count} time";
        else
            ButtonText = $"Clicked {Count} times";

        SemanticScreenReader.Announce(ButtonText);

        _scoreService.IncrementScore();
    }
}
