using CommunityToolkit.Mvvm.ComponentModel;
using Mastermind.Models;
using System;
using System.Linq;

namespace Mastermind.Services;

public partial class GameService : ObservableObject
{
    [ObservableProperty]
    private Game game = new();
    public void RestartGame()
    {
        this.game.Restart();
    }
}