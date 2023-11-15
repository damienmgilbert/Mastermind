using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage(AboutViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}