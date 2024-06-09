using WeatherApp.MVVM.Views;

namespace WeatherApp
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(WelcomePage),typeof(WelcomePage));
            Routing.RegisterRoute(nameof(HomePage),typeof(HomePage));
            Routing.RegisterRoute(nameof(SevenDayWeatherPage),typeof(SevenDayWeatherPage)); 

            
        }
    }
}
