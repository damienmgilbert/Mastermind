using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Mastermind.Models;
using System;
using System.Linq;

namespace Mastermind.ViewModels;

public partial class GameRowPiecesViewModel : BaseViewModel
{
    [ObservableProperty]
    View? selectedPiece;

    [RelayCommand]
    private void SelectPiece(View piece)
    {
        this.SelectedPiece = piece;
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
