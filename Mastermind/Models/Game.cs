using CommunityToolkit.Mvvm.ComponentModel;
using Mastermind.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Models;
public partial class Game : ObservableObject
{

    #region Fields
    [ObservableProperty]
    private GameRow currentRow = new();
    [ObservableProperty]
    private GameRow eighthRow = new();
    [ObservableProperty]
    private GameRow fifthRow = new();
    [ObservableProperty]
    private PieceChoice firstPieceAnswer;
    [ObservableProperty]
    private GameRow firstRow = new();
    [ObservableProperty]
    private PieceChoice fourthPieceAnswer;
    [ObservableProperty]
    private GameRow fourthRow = new();
    [ObservableProperty]
    private bool hasLost;
    [ObservableProperty]
    private bool hasWon;
    [ObservableProperty]
    private PieceChoice secondPieceAnswer;
    [ObservableProperty]
    private GameRow secondRow = new();
    [ObservableProperty]
    private GameRow seventhRow = new();
    [ObservableProperty]
    private GameRow sixthRow = new();
    [ObservableProperty]
    private PieceChoice thirdPieceAnswer;
    [ObservableProperty]
    private GameRow thirdRow = new();
    #endregion

    #region Constructors
    public Game()
    {
        this.Restart();
    }
    #endregion

    #region Public methods
    public async void CheckBoard()
    {
        if (this.CurrentRow.FirstPiece.PieceChoice == this.FirstPieceAnswer)
        {
            this.CurrentRow.GameRowChecker.FirstPieceValidity = ChoiceValidity.PresentAndInPosition;
        }
        else if (this.CurrentRow.FirstPiece.PieceChoice == this.SecondPieceAnswer || this.CurrentRow.FirstPiece.PieceChoice == this.ThirdPieceAnswer || this.CurrentRow.FirstPiece.PieceChoice == this.FourthPieceAnswer)
        {
            this.CurrentRow.GameRowChecker.FirstPieceValidity = ChoiceValidity.Present;
        }
        else
        {
            this.CurrentRow.GameRowChecker.FirstPieceValidity = ChoiceValidity.NotPresent;
        }

        if (this.CurrentRow.SecondPiece.PieceChoice == this.SecondPieceAnswer)
        {
            this.CurrentRow.GameRowChecker.SecondPieceValidity = ChoiceValidity.PresentAndInPosition;
        }
        else if (this.CurrentRow.SecondPiece.PieceChoice == this.FirstPieceAnswer || this.CurrentRow.SecondPiece.PieceChoice == this.ThirdPieceAnswer || this.CurrentRow.SecondPiece.PieceChoice == this.FourthPieceAnswer)
        {
            this.CurrentRow.GameRowChecker.SecondPieceValidity = ChoiceValidity.Present;
        }
        else
        {
            this.CurrentRow.GameRowChecker.SecondPieceValidity = ChoiceValidity.NotPresent;
        }

        if (this.CurrentRow.ThirdPiece.PieceChoice == this.ThirdPieceAnswer)
        {
            this.CurrentRow.GameRowChecker.ThirdPieceValidity = ChoiceValidity.PresentAndInPosition;
        }
        else if (this.CurrentRow.ThirdPiece.PieceChoice == this.FirstPieceAnswer || this.CurrentRow.ThirdPiece.PieceChoice == this.SecondPieceAnswer || this.CurrentRow.ThirdPiece.PieceChoice == this.FourthPieceAnswer)
        {
            this.CurrentRow.GameRowChecker.ThirdPieceValidity = ChoiceValidity.Present;
        }
        else
        {
            this.CurrentRow.GameRowChecker.ThirdPieceValidity = ChoiceValidity.NotPresent;
        }

        if (this.CurrentRow.FourthPiece.PieceChoice == this.FourthPieceAnswer)
        {
            this.CurrentRow.GameRowChecker.FourthPieceValidity = ChoiceValidity.PresentAndInPosition;
        }
        else if (this.CurrentRow.FourthPiece.PieceChoice == this.FirstPieceAnswer || this.CurrentRow.FourthPiece.PieceChoice == this.SecondPieceAnswer || this.CurrentRow.FourthPiece.PieceChoice == this.ThirdPieceAnswer)
        {
            this.CurrentRow.GameRowChecker.FourthPieceValidity = ChoiceValidity.Present;
        }
        else
        {
            this.CurrentRow.GameRowChecker.FourthPieceValidity = ChoiceValidity.NotPresent;
        }

        if (this.CurrentRow.GameRowChecker.FirstPieceValidity == ChoiceValidity.PresentAndInPosition && this.CurrentRow.GameRowChecker.SecondPieceValidity == ChoiceValidity.PresentAndInPosition && this.CurrentRow.GameRowChecker.ThirdPieceValidity == ChoiceValidity.PresentAndInPosition && this.CurrentRow.GameRowChecker.FourthPieceValidity == ChoiceValidity.PresentAndInPosition)
        {
            this.HasWon = true;
        }


        this.CurrentRow.GameRowChecker.IsPlayable = true;
        this.CurrentRow.GameRowChecker.IsCheckable = false;
        this.CurrentRow.GameRowChecker.IsCheckableEnabled = false;

        if (CurrentRow == FirstRow)
        {
            this.CurrentRow.FirstPiece.IsEditable = false;
            this.CurrentRow.SecondPiece.IsEditable = false;
            this.CurrentRow.ThirdPiece.IsEditable = false;
            this.CurrentRow.FourthPiece.IsEditable = false;
            this.CurrentRow = SecondRow;
            this.CurrentRow.GameRowChecker.IsPlayable = false;
            this.CurrentRow.GameRowChecker.IsCheckable = true;
            this.CurrentRow.GameRowChecker.IsCheckableEnabled = false;
            this.CurrentRow.FirstPiece.IsEditable = true;
            this.CurrentRow.SecondPiece.IsEditable = true;
            this.CurrentRow.ThirdPiece.IsEditable = true;
            this.CurrentRow.FourthPiece.IsEditable = true;
        }
        else if (CurrentRow == SecondRow)
        {
            this.CurrentRow.FirstPiece.IsEditable = false;
            this.CurrentRow.SecondPiece.IsEditable = false;
            this.CurrentRow.ThirdPiece.IsEditable = false;
            this.CurrentRow.FourthPiece.IsEditable = false;
            this.CurrentRow = ThirdRow;
            this.CurrentRow.GameRowChecker.IsPlayable = false;
            this.CurrentRow.GameRowChecker.IsCheckable = true;
            this.CurrentRow.GameRowChecker.IsCheckableEnabled = false;
            this.CurrentRow.FirstPiece.IsEditable = true;
            this.CurrentRow.SecondPiece.IsEditable = true;
            this.CurrentRow.ThirdPiece.IsEditable = true;
            this.CurrentRow.FourthPiece.IsEditable = true;
        }
        else if (CurrentRow == ThirdRow)
        {
            this.CurrentRow.FirstPiece.IsEditable = false;
            this.CurrentRow.SecondPiece.IsEditable = false;
            this.CurrentRow.ThirdPiece.IsEditable = false;
            this.CurrentRow.FourthPiece.IsEditable = false;
            this.CurrentRow = FourthRow;
            this.CurrentRow.GameRowChecker.IsPlayable = false;
            this.CurrentRow.GameRowChecker.IsCheckable = true;
            this.CurrentRow.GameRowChecker.IsCheckableEnabled = false;
            this.CurrentRow.FirstPiece.IsEditable = true;
            this.CurrentRow.SecondPiece.IsEditable = true;
            this.CurrentRow.ThirdPiece.IsEditable = true;
            this.CurrentRow.FourthPiece.IsEditable = true;
        }
        else if (CurrentRow == FourthRow)
        {
            this.CurrentRow.FirstPiece.IsEditable = false;
            this.CurrentRow.SecondPiece.IsEditable = false;
            this.CurrentRow.ThirdPiece.IsEditable = false;
            this.CurrentRow.FourthPiece.IsEditable = false;
            this.CurrentRow = FifthRow;
            this.CurrentRow.GameRowChecker.IsPlayable = false;
            this.CurrentRow.GameRowChecker.IsCheckable = true;
            this.CurrentRow.GameRowChecker.IsCheckableEnabled = false;
            this.CurrentRow.FirstPiece.IsEditable = true;
            this.CurrentRow.SecondPiece.IsEditable = true;
            this.CurrentRow.ThirdPiece.IsEditable = true;
            this.CurrentRow.FourthPiece.IsEditable = true;
        }
        else if (CurrentRow == FifthRow)
        {
            this.CurrentRow.FirstPiece.IsEditable = false;
            this.CurrentRow.SecondPiece.IsEditable = false;
            this.CurrentRow.ThirdPiece.IsEditable = false;
            this.CurrentRow.FourthPiece.IsEditable = false;
            this.CurrentRow = SixthRow;
            this.CurrentRow.GameRowChecker.IsPlayable = false;
            this.CurrentRow.GameRowChecker.IsCheckable = true;
            this.CurrentRow.GameRowChecker.IsCheckableEnabled = false;
            this.CurrentRow.FirstPiece.IsEditable = true;
            this.CurrentRow.SecondPiece.IsEditable = true;
            this.CurrentRow.ThirdPiece.IsEditable = true;
            this.CurrentRow.FourthPiece.IsEditable = true;
        }
        else if (CurrentRow == SixthRow)
        {
            this.CurrentRow.FirstPiece.IsEditable = false;
            this.CurrentRow.SecondPiece.IsEditable = false;
            this.CurrentRow.ThirdPiece.IsEditable = false;
            this.CurrentRow.FourthPiece.IsEditable = false;
            this.CurrentRow = SeventhRow;
            this.CurrentRow.GameRowChecker.IsPlayable = false;
            this.CurrentRow.GameRowChecker.IsCheckable = true;
            this.CurrentRow.GameRowChecker.IsCheckableEnabled = false;
            this.CurrentRow.FirstPiece.IsEditable = true;
            this.CurrentRow.SecondPiece.IsEditable = true;
            this.CurrentRow.ThirdPiece.IsEditable = true;
            this.CurrentRow.FourthPiece.IsEditable = true;
        }
        else if (CurrentRow == SeventhRow)
        {
            this.CurrentRow.FirstPiece.IsEditable = false;
            this.CurrentRow.SecondPiece.IsEditable = false;
            this.CurrentRow.ThirdPiece.IsEditable = false;
            this.CurrentRow.FourthPiece.IsEditable = false;
            this.CurrentRow = EighthRow;
            this.CurrentRow.GameRowChecker.IsPlayable = false;
            this.CurrentRow.GameRowChecker.IsCheckable = true;
            this.CurrentRow.GameRowChecker.IsCheckableEnabled = false;
            this.CurrentRow.FirstPiece.IsEditable = true;
            this.CurrentRow.SecondPiece.IsEditable = true;
            this.CurrentRow.ThirdPiece.IsEditable = true;
            this.CurrentRow.FourthPiece.IsEditable = true;
        }
        else if (CurrentRow == EighthRow)
        {
            this.HasLost = true;
        }
    }
    public void Restart()
    {
        this.FirstRow = new();
        this.SecondRow = new();
        this.ThirdRow = new();
        this.FourthRow = new();
        this.FifthRow = new();
        this.SixthRow = new();
        this.SeventhRow = new();
        this.EighthRow = new();

        this.FirstRow.GameRowChecker.IsCheckable = true;
        this.FirstRow.GameRowChecker.IsCheckableEnabled = false;
        this.FirstRow.FirstPiece.IsEditable = true;
        this.FirstRow.SecondPiece.IsEditable = true;
        this.FirstRow.ThirdPiece.IsEditable = true;
        this.FirstRow.FourthPiece.IsEditable = true;
        this.CurrentRow = this.FirstRow;

        this.SecondRow.GameRowChecker.IsPlayable = true;
        this.ThirdRow.GameRowChecker.IsPlayable = true;
        this.FourthRow.GameRowChecker.IsPlayable = true;
        this.FifthRow.GameRowChecker.IsPlayable = true;
        this.SixthRow.GameRowChecker.IsPlayable = true;
        this.SeventhRow.GameRowChecker.IsPlayable = true;
        this.EighthRow.GameRowChecker.IsPlayable = true;

        this.FirstPieceAnswer = GetRandomChoice();
        this.SecondPieceAnswer = GetRandomChoice();
        this.ThirdPieceAnswer = GetRandomChoice();
        this.FourthPieceAnswer = GetRandomChoice();

        PieceChoice GetRandomChoice()
        {
            Random random = new();
            var choices = Enum.GetValues<PieceChoice>().Cast<int>().ToArray();
            int max = choices.Max();
            int value = random.Next(1, max + 1);
            PieceChoice pieceChoice = (PieceChoice)value;
            return pieceChoice;
        }
    }
    #endregion

}
