using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Linq;

namespace Mastermind.ViewModels;

public partial class GameViewModel : BaseViewModel
{
    IPopupService popupService;
    public GameViewModel() 
    {
        this.popupService = Ioc.Default.GetRequiredService<IPopupService>();
        this.Title = "Game";
    }

    [RelayCommand]
    private void SelectPiece(View anchor)
    {
        this.popupService.ShowPopup<SimplePopupViewModel>(onPresenting: viewModel => viewModel.PositionPopup(anchor));
    }
}