using Mastermind.Views;

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
        }
    }
}
