using CommunityToolkit.Mvvm.DependencyInjection;
using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class GamePage : ContentPage
{
	public GamePage()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<GameViewModel>();
	}
}