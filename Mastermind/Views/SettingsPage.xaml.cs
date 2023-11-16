using CommunityToolkit.Mvvm.DependencyInjection;
using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class SettingsPage : ContentPage
{
	public SettingsPage()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<SettingsViewModel>();
	}
}