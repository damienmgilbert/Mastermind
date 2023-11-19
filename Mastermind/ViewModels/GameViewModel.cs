using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using Mastermind.Models;
using Mastermind.Services;
using Mastermind.Views;
using System;
using System.Linq;

namespace Mastermind.ViewModels;

public partial class GameViewModel : BaseViewModel
{
    GameService gameService;

    public GameViewModel() 
    {
        this.gameService = Ioc.Default.GetRequiredService<GameService>();
        this.Title = "Game";

        this.Game.PropertyChanged += Game_PropertyChanged;
    }

    static Page Page => Application.Current?.MainPage ?? throw new NullReferenceException();

    private async void Game_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        string propertyName = e.PropertyName ?? string.Empty;
        if (propertyName == nameof(Game.HasWon))
        {
            if (Game.HasWon)
            {
                MessagePopup messagePopup = new() { Message = "You won!" };
                var result = await Page.ShowPopupAsync(messagePopup);
                this.gameService.RestartGame();
            }
            return;
        }

        if (propertyName == nameof(Game.HasLost))
        {
            if (Game.HasLost)
            {
                MessagePopup messagePopup = new() { Message = "You lost!" };
                var result = await Page.ShowPopupAsync(messagePopup);
                this.gameService.RestartGame();
            }
            return;
        }
    }

    public Game Game { get => gameService.Game; set => gameService.Game = value; }
}
