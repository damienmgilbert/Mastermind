using Mastermind.Resources.Styles;
using Mastermind.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mastermind.ViewModels;
public class HomeViewModel : BaseViewModel
{
    private readonly AppThemeService appThemeService;

    public HomeViewModel(AppThemeService appThemeService)
    {
        this.appThemeService = appThemeService;
        this.Title = "Home";
        
        this.ChangeThemeCommand = new Command(() =>
        {
            this.appThemeService.ChangeTheme();
        });
    }

    public ICommand ChangeThemeCommand { get; private set; }
}
