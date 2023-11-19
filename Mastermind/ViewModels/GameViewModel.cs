using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using Mastermind.Models;
using Mastermind.Services;
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
    }

    public Game Game { get => gameService.Game; set => gameService.Game = value; }
}
