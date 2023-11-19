using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.ViewModels;
public partial class BaseViewModel : ObservableRecipient
{
    [ObservableProperty]
    private string title = string.Empty;
}
