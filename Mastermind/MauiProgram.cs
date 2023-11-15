using Mastermind.Services;
using Mastermind.ViewModels;
using Mastermind.Views;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Mastermind
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .RegisterViewModels()
                .RegisterViews()
                .RegisterServices()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }

        private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<AboutViewModel>();
            builder.Services.AddTransient<SettingsViewModel>();
            return builder;
        }

        private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<AboutPage>();
            builder.Services.AddTransient<SettingsPage>();
            return builder;
        }

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<AppThemeService>();
            return builder; 
        }
    }
}
