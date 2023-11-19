using CommunityToolkit.Mvvm.ComponentModel;
using Mastermind.Models;
using System;
using System.Linq;

namespace Mastermind.ViewModels;
public partial class GameRowViewModel : BaseViewModel
{
    [ObservableProperty]
    private GameRow gameRow = new();
}