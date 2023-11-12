using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class HomePage : ContentPage
{
	public HomePage(HomeViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}