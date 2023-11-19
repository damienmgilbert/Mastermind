using CommunityToolkit.Mvvm.ComponentModel;
using Mastermind.Models;
using Mastermind.Resources.Styles;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.Services;

public class AppThemeService : INotifyPropertyChanged
{
    private AppTheme appTheme;

    public event PropertyChangedEventHandler? PropertyChanged;

    public AppTheme AppTheme { get => appTheme; set
        {
            if (appTheme == value) return;
            appTheme = value;
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(AppTheme)));
        }
    }

    public void ChangeTheme()
    {
        Func<AppTheme> themeAction = this.AppTheme switch
        {
            AppTheme.Light => ChangeToDarkTheme()
            ,
            AppTheme.Dark => ChangeToLightTheme()

            ,
            _ => throw new NotImplementedException()
        };

        this.AppTheme = themeAction();

        static Func<AppTheme> ChangeToDarkTheme()
        {
            return () =>
            {
                ICollection<ResourceDictionary> mergedDictionaries = Application.Current!.Resources.MergedDictionaries;
                mergedDictionaries.Clear();
                Resources.Styles.DarkTheme newTheme = [];
                mergedDictionaries.Add(newTheme);
                return AppTheme.Dark;
            };
        }

        static Func<AppTheme> ChangeToLightTheme()
        {
            return () =>
            {
                ICollection<ResourceDictionary> mergedDictionaries = Application.Current!.Resources.MergedDictionaries;
                mergedDictionaries.Clear();
                Resources.Styles.LightTheme newTheme = [];
                mergedDictionaries.Add(newTheme);
                return AppTheme.Light;
            };
        }
    }
}
