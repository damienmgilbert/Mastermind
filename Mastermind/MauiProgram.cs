using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.DependencyInjection;
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
                // Initialize the .NET MAUI Community Toolkit by adding the below line of code
                .UseMauiCommunityToolkit()
                .RegisterViewModels()
                .RegisterViews()
                .RegisterRoutes()
                .RegisterServices()
                .RegisterPopups()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif
            
            Ioc.Default.ConfigureServices(builder.Services.BuildServiceProvider());
            
            return builder.Build();
        }

        private static MauiAppBuilder RegisterPopups(this MauiAppBuilder builder)
        {
            //builder.Services.AddTransientPopup<SimplePopup, SimplePopupViewModel>();
            return builder;
        }

        private static MauiAppBuilder RegisterViewModels(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<GameRowPiecesViewModel>();
            builder.Services.AddTransient<CheckBoardViewModel>();
            return builder;
        }

        private static MauiAppBuilder RegisterViews(this MauiAppBuilder builder)
        {
            builder.Services.AddTransient<GameRowPiecesView>();
            builder.Services.AddTransient<CheckBoardView>();
            builder.Services.AddTransient<SimplePopup>();
            return builder;
        }

        private static MauiAppBuilder RegisterRoutes(this MauiAppBuilder builder)
        {
            builder.Services.AddTransientWithShellRoute<HomePage, HomeViewModel>("Home");
            builder.Services.AddTransientWithShellRoute<AboutPage, AboutViewModel>("About");
            builder.Services.AddTransientWithShellRoute<SettingsPage, SettingsViewModel>("Setting");
            builder.Services.AddTransientWithShellRoute<GamePage, GameViewModel>("Game");
            return builder;
        }

        private static MauiAppBuilder RegisterServices(this MauiAppBuilder builder)
        {
            builder.Services.AddSingleton<AppThemeService>();
            builder.Services.AddSingleton<GameService>();
            return builder; 
        }
    }
}
