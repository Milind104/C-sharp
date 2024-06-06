using WeatherApp.MVVM.ViewModels;

namespace WeatherApp.MVVM.Views
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomePageViewModel();
        }
    }
}
