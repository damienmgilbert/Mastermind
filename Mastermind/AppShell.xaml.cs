using CommunityToolkit.Mvvm.Input;
using Mastermind.ViewModels;
using Mastermind.Views;
using System.Windows.Input;

namespace Mastermind
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void NavigationButton_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Shell.Current.GoToAsync($"//{button.Text}");
        }
    }
}
