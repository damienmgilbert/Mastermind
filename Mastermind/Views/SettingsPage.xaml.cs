using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}