using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MonkeyFinder.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        bool isBusy;
        string title;

        public bool IsBusy
        {
            get => isBusy;
            set
            {
                if (isBusy == value)
                    return;
                isBusy = value;
                OnPropertyChanged();

                OnPropertyChanged(nameof(IsNotBusy));
                
            }
        }

        public bool IsNotBusy => !IsBusy;

        public string Title
        {
            get => Title;
            set
            {
                if (Title == value)
                    return;
                Title = value;
                OnPropertyChanged();

            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = null )=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
