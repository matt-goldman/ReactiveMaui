using Microsoft.Extensions.Logging;
using ReactiveMaui.Services;
using ReactiveMaui.ViewModels;

namespace ReactiveMaui
{
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

            // Pages
            builder.Services.AddTransient<MainPage>();
            builder.Services.AddSingleton<AppShell>();

            // ViewModels
            builder.Services.AddTransient<MainViewModel>();
            builder.Services.AddTransient<ShellViewModel>();

            // Services
            builder.Services.AddSingleton<ScoreService>();

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
