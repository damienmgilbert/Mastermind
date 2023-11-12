using System.ComponentModel;

namespace Mastermind
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        private string themeSource = "Resources/Styles/LightTheme.xaml";

        public string ThemeSource
        {
            get
            {
                return themeSource;
            }
            set
            {
                if (themeSource != value)
                {
                    themeSource = value;
                    OnPropertyChanged(nameof(ThemeSource));
                }
            }
        }
    }
}
