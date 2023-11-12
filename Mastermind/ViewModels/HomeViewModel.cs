using Mastermind.Resources.Styles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Mastermind.ViewModels;
public class HomeViewModel : BaseViewModel
{
    public HomeViewModel()
    {
        this.Title = "Home";
        
        this.ChangeThemeCommand = new Command(() =>
        {
            //ICollection<ResourceDictionary> mergedDictionaries = Application.Current!.Resources.MergedDictionaries;

            //var dictionaries = mergedDictionaries.ToList();
            //bool isLightTheme = IsThemePresent(dictionaries, "Resources/Styles/LightTheme.xaml;assembly=Mastermind", out ResourceDictionary? lightTheme);
            //bool isDarkTheme = IsThemePresent(dictionaries, "Resources/Styles/DarkTheme.xaml;assembly=Mastermind", out ResourceDictionary? darkTheme);
            //if (isLightTheme)
            //{
            //    mergedDictionaries.Remove(lightTheme);
            //    DarkTheme newTheme = [];
            //    mergedDictionaries.Add(Mastermind.Resources.Styles.);
            //}
            //else if (isDarkTheme)
            //{
            //    mergedDictionaries.Remove(darkTheme);
            //    LightTheme newTheme = [];
            //    mergedDictionaries.Add(newTheme);
            //}

            //static bool IsThemePresent(List<ResourceDictionary> dictionaries, string originalString, out ResourceDictionary? resourceDictionary)
            //{
            //    bool isThemePresent = false;
            //    resourceDictionary = null;
            //    try
            //    {
            //        ResourceDictionary? theme = dictionaries.Find(_ => _.Source.OriginalString == originalString);
            //        if (theme is not null)
            //        {
            //            isThemePresent = true;
            //        }
            //        resourceDictionary = theme;
            //    }
            //    catch (Exception ex)
            //    {
            //        // light theme is not present
            //    }
            //    return isThemePresent;
            //}
        });
    }

    public ICommand ChangeThemeCommand { get; private set; }
}
