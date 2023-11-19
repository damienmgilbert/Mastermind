using CommunityToolkit.Mvvm.ComponentModel;
using Mastermind.Models;
using System;
using System.ComponentModel;
using System.Globalization;
using System.Linq;

namespace Mastermind.ViewModels;

/// <summary>
/// TODO: Needs documentation.
/// </summary>
public partial class CheckBoardViewModel : ObservableRecipient
{
    #region Fields
    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    [ObservableProperty]
    private ChoiceValidity firstPieceValidity;

    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    [ObservableProperty]
    private ChoiceValidity fourthPieceValidity;

    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    [ObservableProperty]
    private bool isCheckable;

    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    [ObservableProperty]
    private bool isCheckableEnabled;

    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    [ObservableProperty]
    private bool isPlayable;

    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    [ObservableProperty]
    private ChoiceValidity secondPieceValidity;

    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    [ObservableProperty]
    private ChoiceValidity thirdPieceValidity;
    #endregion

    #region Constructors
    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    public CheckBoardViewModel() { this.PropertyChanged += CheckBoardViewModel_PropertyChanged; }
    #endregion

    #region Destructors
    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    ~CheckBoardViewModel() { this.PropertyChanged -= CheckBoardViewModel_PropertyChanged; }
    #endregion

    #region Private methods
    /// <summary>
    /// TODO: Needs documentation.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CheckBoardViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
    {
        string propertyName = e.PropertyName ?? string.Empty;
        switch(propertyName)
        {
            case nameof(IsCheckable):
            {
                this.IsPlayable = !this.IsCheckable;
                break;
            }
            case nameof(IsPlayable):
            {
                this.IsCheckable = !this.IsPlayable;
                break;
            }
        }
    }
    #endregion
}
