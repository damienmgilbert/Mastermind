using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;

namespace Mastermind.Views;

public partial class MessagePopup : Popup
{
	public MessagePopup()
	{
		InitializeComponent();
	}

	[RelayCommand]
	private async Task RestartGame() => await this.CloseAsync(true);

	public static readonly BindableProperty MessageProperty = BindableProperty.Create(nameof(Message), typeof(string), typeof(MessagePopup), string.Empty);

	public string Message
	{
		get => (string)GetValue(MessageProperty);
		set => SetValue(MessageProperty, value);
	}
}