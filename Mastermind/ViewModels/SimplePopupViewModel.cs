using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Linq;

namespace Mastermind.ViewModels;
public partial class SimplePopupViewModel : ObservableRecipient
{
    [ObservableProperty]
    private View? anchor;

    public void PositionPopup(View view)
    {
        this.Anchor = view;
    }
}
