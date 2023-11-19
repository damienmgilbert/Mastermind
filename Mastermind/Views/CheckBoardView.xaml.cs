using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using Mastermind.Models;
using Mastermind.Services;
using Mastermind.ViewModels;

namespace Mastermind.Views;
public partial class CheckBoardView : ContentView
{

    #region Fields
    public static readonly BindableProperty FirstPieceValidityProperty = BindableProperty.Create(nameof(FirstPieceValidity), typeof(ChoiceValidity), typeof(CheckBoardView), default(ChoiceValidity));
    public static readonly BindableProperty FourthPieceValidityProperty = BindableProperty.Create(nameof(FourthPieceValidity), typeof(ChoiceValidity), typeof(CheckBoardView), default(ChoiceValidity));
    public static readonly BindableProperty IsCheckableEnabledProperty = BindableProperty.Create(nameof(IsCheckableEnabled), typeof(bool), typeof(CheckBoardView), default(bool));
    public static readonly BindableProperty IsCheckableProperty = BindableProperty.Create(nameof(IsCheckable), typeof(bool), typeof(CheckBoardView), default(bool));
    public static readonly BindableProperty IsPlayableProperty = BindableProperty.Create(nameof(IsPlayable), typeof(bool), typeof(CheckBoardView), default(bool));
    public static readonly BindableProperty SecondPieceValidityProperty = BindableProperty.Create(nameof(SecondPieceValidity), typeof(ChoiceValidity), typeof(CheckBoardView), default(ChoiceValidity));
    public static readonly BindableProperty ThirdPieceValidityProperty = BindableProperty.Create(nameof(ThirdPieceValidity), typeof(ChoiceValidity), typeof(CheckBoardView), default(ChoiceValidity));
    GameService gameService;
    #endregion

    #region Constructors
    public CheckBoardView()
    {
        InitializeComponent();
        this.gameService = Ioc.Default.GetRequiredService<GameService>();
        //this.BindingContext = Ioc.Default.GetRequiredService<CheckBoardViewModel>();
    }
    #endregion

    #region Public properties
    public ChoiceValidity FirstPieceValidity
    {
        get => (ChoiceValidity)GetValue(CheckBoardView.FirstPieceValidityProperty);
        set => SetValue(CheckBoardView.FirstPieceValidityProperty, value);
    }
    public ChoiceValidity FourthPieceValidity
    {
        get => (ChoiceValidity)GetValue(CheckBoardView.FourthPieceValidityProperty);
        set => SetValue(CheckBoardView.FourthPieceValidityProperty, value);
    }

    [RelayCommand]
    private void CheckRow()
    {
        this.gameService.Game.CheckBoard();
    }

    public bool IsCheckable
    {
        get => (bool)GetValue(CheckBoardView.IsCheckableProperty);
        set => SetValue(CheckBoardView.IsCheckableProperty, value);
    }
    public bool IsCheckableEnabled
    {
        get => (bool)GetValue(CheckBoardView.IsCheckableEnabledProperty);
        set => SetValue(CheckBoardView.IsCheckableEnabledProperty, value);
    }
    public bool IsPlayable
    {
        get => (bool)GetValue(CheckBoardView.IsPlayableProperty);
        set => SetValue(CheckBoardView.IsPlayableProperty, value);
    }
    public ChoiceValidity SecondPieceValidity
    {
        get => (ChoiceValidity)GetValue(CheckBoardView.SecondPieceValidityProperty);
        set => SetValue(CheckBoardView.SecondPieceValidityProperty, value);
    }
    public ChoiceValidity ThirdPieceValidity
    {
        get => (ChoiceValidity)GetValue(CheckBoardView.ThirdPieceValidityProperty);
        set => SetValue(CheckBoardView.ThirdPieceValidityProperty, value);
    }
    #endregion

}