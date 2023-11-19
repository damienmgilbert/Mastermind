using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Linq;

namespace Mastermind.Models;

public partial class GameRowChecker : ObservableObject
{
    public GameRowChecker()
    {
        this.PropertyChanged += GameRowChecker_PropertyChanged;
    }

    private void GameRowChecker_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        string propertyName = e.PropertyName ?? string.Empty;
        if (propertyName is (nameof(IsFirstPieceChosen)) or (nameof(IsSecondPieceChosen)) or (nameof(IsThirdPieceChosen)) or (nameof(IsFourthPieceChosen)))
        {
            if (this.IsFirstPieceChosen && this.IsSecondPieceChosen && this.IsThirdPieceChosen && this.IsFourthPieceChosen)
            {
                this.IsCheckable = true;
                this.IsCheckableEnabled = true;
            }
        }
    }

    [ObservableProperty]
    private bool isPlayable;

    [ObservableProperty]
    private bool isCheckable;

    [ObservableProperty]
    private bool isCheckableEnabled;

    [ObservableProperty]
    private bool isFirstPieceChosen;

    [ObservableProperty]
    private bool isSecondPieceChosen;

    [ObservableProperty]
    private bool isThirdPieceChosen;

    [ObservableProperty]
    private bool isFourthPieceChosen;

    [ObservableProperty]
    private ChoiceValidity firstPieceValidity;

    [ObservableProperty]
    private ChoiceValidity secondPieceValidity;

    [ObservableProperty]
    private ChoiceValidity thirdPieceValidity;

    [ObservableProperty]
    private ChoiceValidity fourthPieceValidity;
}