using CommunityToolkit.Maui.Core;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using Mastermind.Resources.Styles;
using Mastermind.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mastermind.ViewModels;
public partial class HomeViewModel : BaseViewModel
{
    private readonly AppThemeService appThemeService;

    public HomeViewModel()
    {
        this.appThemeService = Ioc.Default.GetRequiredService<AppThemeService>();
        this.popupService = Ioc.Default.GetRequiredService<IPopupService>();
        this.Title = "Home";
    }

    [RelayCommand]
    private void ShowPopup()
    {
        //this.IsPopoverVisible = !this.IsPopoverVisible;
        this.popupService.ShowPopup<SimplePopupViewModel>();
    }

    [ObservableProperty]
    bool isPopoverVisible;
    IPopupService popupService;

    [RelayCommand]
    private void ChangeTheme()
    {
        this.appThemeService.ChangeTheme();
    }
}
