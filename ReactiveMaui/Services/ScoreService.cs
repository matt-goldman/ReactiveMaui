using ReactiveMaui.Helpers;

namespace ReactiveMaui.Services;

public class ScoreService
{
    private State<int> _score;

    public ScoreService()
    {
        _score = new State<int>(0);
    }

    public void IncrementScore()
    {
        _score.SetValue(_score.CurrentValue + 1);
    }

    public IDisposable SubscribeToScore(Action<int> onChange) 
        => _score.Subscribe(onChange);
}
