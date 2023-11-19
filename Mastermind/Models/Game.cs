using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Models;
public partial class Game : ObservableObject
{
    public Game()
    {
        this.FirstRow.GameRowChecker.IsCheckable = true;
        this.FirstRow.FirstPiece.IsEditable = true;
        this.FirstRow.SecondPiece.IsEditable = true;
        this.FirstRow.ThirdPiece.IsEditable = true;
        this.FirstRow.FourthPiece.IsEditable = true;
        this.SecondRow.GameRowChecker.IsPlayable = true;
        this.ThirdRow.GameRowChecker.IsPlayable = true;
        this.FourthRow.GameRowChecker.IsPlayable = true;
        this.FifthRow.GameRowChecker.IsPlayable = true;
        this.SixthRow.GameRowChecker.IsPlayable = true;
        this.SeventhRow.GameRowChecker.IsPlayable = true;
        this.EighthRow.GameRowChecker.IsPlayable = true;

        this.FirstPieceAnswer = PieceChoice.Red;
        this.SecondPieceAnswer = PieceChoice.Red;
        this.ThirdPieceAnswer = PieceChoice.Red;
        this.FourthPieceAnswer = PieceChoice.Red;
    }

    [ObservableProperty]
    private PieceChoice firstPieceAnswer;

    [ObservableProperty]
    private PieceChoice secondPieceAnswer;

    [ObservableProperty]
    private PieceChoice thirdPieceAnswer;

    [ObservableProperty]
    private PieceChoice fourthPieceAnswer;

    [ObservableProperty]
    private GameRow firstRow = new();

    [ObservableProperty]
    private GameRow secondRow = new();

    [ObservableProperty]
    private GameRow thirdRow = new();

    [ObservableProperty]
    private GameRow fourthRow = new();

    [ObservableProperty]
    private GameRow fifthRow = new();

    [ObservableProperty]
    private GameRow sixthRow = new();

    [ObservableProperty]
    private GameRow seventhRow = new();

    [ObservableProperty]
    private GameRow eighthRow = new();
}
