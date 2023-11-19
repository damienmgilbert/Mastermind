using Mastermind.Models;

namespace Mastermind.Views;

public partial class GameRowView : ContentView
{
	public GameRowView()
	{
		InitializeComponent();
	}

    public static readonly BindableProperty GameRowProperty = BindableProperty.Create(nameof(GameRow), typeof(GameRow), typeof(GameRowView), default(GameRow));

    public GameRow GameRow
    {
        get => (GameRow)GetValue(GameRowProperty);
        set => SetValue(GameRowProperty, value);
    }
}