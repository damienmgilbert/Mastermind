using CommunityToolkit.Mvvm.DependencyInjection;
using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<AboutViewModel>();
	}
}