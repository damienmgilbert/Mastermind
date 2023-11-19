using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.DependencyInjection;
using Mastermind.ViewModels;

namespace Mastermind.Views;

public partial class SimplePopup : Popup
{
	public SimplePopup()
	{
		InitializeComponent();
		this.BindingContext = Ioc.Default.GetRequiredService<SimplePopupViewModel>();
	}
}