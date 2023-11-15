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
            this.RegisterRoutes();
        }

        private void RegisterRoutes()
        {
            Routing.RegisterRoute("Home", typeof(HomePage));
            Routing.RegisterRoute("About", typeof(AboutPage));
            Routing.RegisterRoute("Settings", typeof(SettingsPage));
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Shell.Current.GoToAsync($"//{button.Text}");
        }
    }
}
