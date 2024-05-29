using MauiApp7.MVVM.Views;

namespace MauiApp7
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage =  new NavigationPage( new PageOne());
        }
    }
}
