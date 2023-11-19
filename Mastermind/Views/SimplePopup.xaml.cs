using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using Mastermind.Models;
using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class SimplePopup : Popup
{
	public SimplePopup()
	{
		InitializeComponent();
		//this.BindingContext = Ioc.Default.GetRequiredService<SimplePopupViewModel>();
	}


	[RelayCommand]
	private async Task ColorSelection(PieceChoice choice) => await this.CloseAsync(choice);
}