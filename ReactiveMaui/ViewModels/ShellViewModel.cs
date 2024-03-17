using CommunityToolkit.Mvvm.ComponentModel;
using ReactiveMaui.Services;

namespace ReactiveMaui.ViewModels;

public partial class ShellViewModel : ObservableObject, IDisposable
{
    private readonly ScoreService _scoreService;

    [ObservableProperty]
    private string _scoreMessage = "Score: 0";

    private IDisposable? _scoreSubscription;

    public ShellViewModel(ScoreService scoreService)
    {
        _scoreService = scoreService;
        SubscribeToScore();
    }

    public void Dispose()
    {
        _scoreSubscription?.Dispose();
    }

    private void SubscribeToScore()
    {
        _scoreSubscription = _scoreService.SubscribeToScore(score 
            => ScoreMessage = $"Score: {score}");
    }
}
