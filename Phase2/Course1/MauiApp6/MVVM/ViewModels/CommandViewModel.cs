using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp6.MVVM.ViewModels
{
    class CommandViewModel
    {
        public ICommand BtnClickCommand =>
            new Command(() => App.Current.MainPage.DisplayAlert("First Command", "You clicked the button", "OK"));
    }
}
