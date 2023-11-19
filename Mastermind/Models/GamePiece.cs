using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Linq;

namespace Mastermind.Models;

public partial class GamePiece : ObservableObject
{
    [ObservableProperty]
    private Color backgroundColor = Colors.Transparent;

    [ObservableProperty]
    private bool isEditable;

    [ObservableProperty]
    private PieceChoice pieceChoice = PieceChoice.None;
}
