using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;

namespace Mastermind.Views;

public partial class GamePieceView : ContentView
{
    static Page Page => Application.Current?.MainPage ?? throw new NullReferenceException();

    public GamePieceView()
	{
		InitializeComponent();
	}

	[RelayCommand]
	private void Selected(Button button)
	{
		var popup = new SimplePopup()
		{
			Anchor = button
		};
		Page.ShowPopup(popup);
	}
}