using System.ComponentModel;
using Mastermind.ViewModels;
namespace Mastermind
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
}
