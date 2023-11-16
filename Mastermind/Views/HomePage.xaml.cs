using CommunityToolkit.Mvvm.DependencyInjection;
using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<HomeViewModel>();
	}
}