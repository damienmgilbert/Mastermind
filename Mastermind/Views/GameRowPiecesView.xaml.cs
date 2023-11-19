using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using Mastermind.Models;
using Mastermind.ViewModels;

namespace Mastermind.Views;
public partial class GameRowPiecesView : ContentView
{

    #region Fields
    public static readonly BindableProperty FirstPieceProperty = BindableProperty.Create(nameof(FirstPiece), typeof(GamePiece), typeof(GameRowPiecesView), default(GamePiece));
    public static readonly BindableProperty FourthPieceProperty = BindableProperty.Create(nameof(FourthPiece), typeof(GamePiece), typeof(GameRowPiecesView), default(GamePiece));
    public static readonly BindableProperty SecondPieceProperty = BindableProperty.Create(nameof(SecondPiece), typeof(GamePiece), typeof(GameRowPiecesView), default(GamePiece));
    public static readonly BindableProperty ThirdPieceProperty = BindableProperty.Create(nameof(ThirdPiece), typeof(GamePiece), typeof(GameRowPiecesView), default(GamePiece));


    public static readonly BindableProperty SelectedGamePieceProperty = BindableProperty.Create(nameof(SelectedGamePiece), typeof(GamePiece), typeof(GameRowPiecesView), default(GamePiece));

    public GamePiece SelectedGamePiece
    {
        get => (GamePiece)GetValue(SelectedGamePieceProperty);
        set => SetValue(SelectedGamePieceProperty, value);
    }

    public View SelectedView
    {
        get => (View)GetValue(SelectedViewProperty);
        set => SetValue(SelectedViewProperty, value);
    }

    public static readonly BindableProperty SelectedViewProperty = BindableProperty.Create(nameof(SelectedView), typeof(View), typeof(GameRowPiecesView), default(GamePiece));
    #endregion

    static Page Page => Application.Current?.MainPage ?? throw new NullReferenceException();

    #region Constructors
    public GameRowPiecesView()
    {
        InitializeComponent();
        //this.BindingContext = Ioc.Default.GetRequiredService<GameRowPiecesViewModel>();
    }
    #endregion

    [RelayCommand]
    private async Task SelectPiece(View view)
    {
        this.SelectedView = view;
        switch (view.StyleId)
        {
            case "p1":
                {
                    this.SelectedGamePiece = FirstPiece;
                    break;
                }
            case "p2":
                {
                    this.SelectedGamePiece = SecondPiece;
                    break;
                }
            case "p3":
                {
                    this.SelectedGamePiece = ThirdPiece;
                    break;
                }
            case "p4":
                {
                    this.SelectedGamePiece = FourthPiece;
                    break;
                }
        }
        var popup = new SimplePopup()
        {
            Anchor = view
        };
        var result = await Page.ShowPopupAsync(popup);
        if (result is PieceChoice pieceChoice)
        {
            switch (pieceChoice)
            {
                case PieceChoice.None:
                    break;
                case PieceChoice.Red:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#e11d48");
                        break;
                    }
                case PieceChoice.Blue:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#3b82f6");
                        break;
                    }
                case PieceChoice.Green:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#22c55e");
                        break;
                    }
                case PieceChoice.Orange:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#f97316");
                        break;
                    }
                case PieceChoice.Purple:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#7c3aed");
                        break;
                    }
                case PieceChoice.Brown:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#92400e");
                        break;
                    }
                case PieceChoice.Gray:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#94a3b8");
                        break;
                    }
                case PieceChoice.Pink:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#d946ef");
                        break;
                    }
                case PieceChoice.Yellow:
                    {
                        this.SelectedGamePiece.BackgroundColor = Color.FromArgb("#fbbf24");
                        break;
                    }
                default:
                    break;
            }
            this.SelectedGamePiece.PieceChoice = pieceChoice;
        }
    }

    #region Public properties
    public GamePiece FirstPiece
    {
        get => (GamePiece)GetValue(FirstPieceProperty);
        set => SetValue(FirstPieceProperty, value);
    }
    public GamePiece FourthPiece
    {
        get => (GamePiece)GetValue(FourthPieceProperty);
        set => SetValue(FourthPieceProperty, value);
    }
    public GamePiece SecondPiece
    {
        get => (GamePiece)GetValue(SecondPieceProperty);
        set => SetValue(SecondPieceProperty, value);
    }
    public GamePiece ThirdPiece
    {
        get => (GamePiece)GetValue(ThirdPieceProperty);
        set => SetValue(ThirdPieceProperty, value);
    }
    #endregion

}