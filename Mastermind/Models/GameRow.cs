using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections;
using System.Linq;

namespace Mastermind.Models;

public partial class GameRow : ObservableObject
{
    [ObservableProperty]
    private GameRowChecker gameRowChecker = new();

    public GameRow()
    {
        this.FirstPiece.PropertyChanged += FirstPiece_PropertyChanged;
        this.SecondPiece.PropertyChanged += SecondPiece_PropertyChanged;
        this.ThirdPiece.PropertyChanged += ThirdPiece_PropertyChanged;
        this.FourthPiece.PropertyChanged += FourthPiece_PropertyChanged;
    }

    private void FourthPiece_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        string propertyName = e.PropertyName ?? string.Empty;
        if (propertyName == nameof(GamePiece.BackgroundColor))
        {
            this.GameRowChecker.IsFourthPieceChosen = true;
        }
    }

    private void ThirdPiece_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        string propertyName = e.PropertyName ?? string.Empty;
        if (propertyName == nameof(GamePiece.BackgroundColor))
        {
            this.GameRowChecker.IsThirdPieceChosen = true;
        }
    }

    private void SecondPiece_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        string propertyName = e.PropertyName ?? string.Empty;
        if (propertyName == nameof(GamePiece.BackgroundColor))
        {
            this.GameRowChecker.IsSecondPieceChosen = true;
        }
    }

    private void FirstPiece_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        string propertyName = e.PropertyName ?? string.Empty;
        if (propertyName == nameof(GamePiece.BackgroundColor))
        {
            this.GameRowChecker.IsFirstPieceChosen = true;
        }
    }

    [ObservableProperty]
    private GamePiece firstPiece = new();

    [ObservableProperty]
    private GamePiece secondPiece = new();

    [ObservableProperty]
    private GamePiece thirdPiece = new();

    [ObservableProperty]
    private GamePiece fourthPiece = new();
}
