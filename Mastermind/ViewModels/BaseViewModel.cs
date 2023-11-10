using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind.ViewModels;
public abstract class BaseViewModel
{
    public virtual void OnPropertyChanged(object sender, PropertyChangedEventArgs e) => this.PropertyChanged?.Invoke(sender, e);
    private event PropertyChangedEventHandler? PropertyChanged;

    private string title = string.Empty;
    public required string Title 
    { 
        get => this.title; set
        {
            if (this.title != value)
            {
                this.title = value;
                this.OnPropertyChanged(this, new PropertyChangedEventArgs(nameof(Title)));
            }
        } 
    }
}
