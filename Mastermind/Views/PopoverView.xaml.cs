using System.Windows.Input;

namespace Mastermind.Views;
[ContentProperty(nameof(Content))]
public partial class PopoverView : ContentView
{
    public static readonly BindableProperty ParentViewProperty =
        BindableProperty.Create(nameof(ParentView), typeof(View), typeof(PopoverView));

    public static readonly BindableProperty AnchorElementProperty =
        BindableProperty.Create(nameof(AnchorElement), typeof(View), typeof(PopoverView));

    public static readonly BindableProperty IsVisibleProperty =
        BindableProperty.Create(nameof(IsVisible), typeof(bool), typeof(PopoverView), default(bool), propertyChanged: IsVisibleChanged);

    public View ParentView
    {
        get => (View)GetValue(ParentViewProperty);
        set => SetValue(ParentViewProperty, value);
    }

    public View AnchorElement
    {
        get => (View)GetValue(AnchorElementProperty);
        set => SetValue(AnchorElementProperty, value);
    }

    public bool IsVisible
    {
        get => (bool)GetValue(IsVisibleProperty);
        set => SetValue(IsVisibleProperty, value);
    }

    public PopoverView()
    {
        InitializeComponent();
    }

    public void ShowRelativeTo(View parentView, View anchorView)
    {
        //var parentbou
        //var anchorPosition = anchorView.Bounds;
        //this.TranslateTo(anchorView.X, anchorView.Y);
    }

    static void IsVisibleChanged(global::Microsoft.Maui.Controls.BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is not PopoverView popoverView) return;

        if (popoverView.IsVisible)
        {
            popoverView.ShowRelativeTo(popoverView.ParentView, popoverView.AnchorElement); 
        }
    }

}