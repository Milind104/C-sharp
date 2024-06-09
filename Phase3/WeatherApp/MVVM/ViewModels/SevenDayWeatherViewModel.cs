using CommunityToolkit.Mvvm.ComponentModel;

using WeatherApp.MVVM.Models;

namespace WeatherApp.MVVM.ViewModels
{
    public partial class SevenDayWeatherViewModel : ObservableObject
    {
        [ObservableProperty]
        private List<WeatherInfo> sevenDayWeather;

        public SevenDayWeatherViewModel()
        {
            LoadSampleData();
        }

        private void LoadSampleData()   
        {
            SevenDayWeather = new List<WeatherInfo>
            {
                new WeatherInfo { DayOfWeek = "Monday", WeatherIcon = "w_01d.png", MaxTemp = "25°C", MinTemp = "15°C", Cloudiness = "10% Cloudy" ,Sunrise ="5:15 AM" , Sunset="6:30 PM", Pressure ="1017 hPa"},
    
                new WeatherInfo { DayOfWeek = "Tuesday", WeatherIcon = "w_01n.png", MaxTemp = "22°C", MinTemp = "14°C", Cloudiness = "20% Cloudy", Sunrise = "5:15 AM", Sunset = "6:30 PM", Pressure = "1017 hPa" },

                new WeatherInfo { DayOfWeek = "Wednesday", WeatherIcon = "w_02d.png", MaxTemp = "20°C", MinTemp = "13°C", Cloudiness = "60% Cloudy", Sunrise = "5:15 AM", Sunset = "6:30 PM", Pressure = "1017 hPa" },


                new WeatherInfo { DayOfWeek = "Thursday", WeatherIcon = "w_02n.png", MaxTemp = "18°C", MinTemp = "12°C", Cloudiness = "80% Cloudy", Sunrise = "5:15 AM", Sunset = "6:30 PM", Pressure = "1017 hPa" },


                new WeatherInfo { DayOfWeek = "Friday", WeatherIcon = "w_03d.png", MaxTemp = "24°C", MinTemp = "16°C", Cloudiness = "10% Cloudy", Sunrise = "5:15 AM", Sunset = "6:30 PM", Pressure = "1017 hPa" },


                new WeatherInfo { DayOfWeek = "Saturday", WeatherIcon = "w_03n.png", MaxTemp = "23°C", MinTemp = "15°C", Cloudiness = "30% Cloudy", Sunrise = "5:15 AM", Sunset = "6:30 PM", Pressure = "1017 hPa" },

                new WeatherInfo { DayOfWeek = "Sunday", WeatherIcon = "w_04d.png", MaxTemp = "19°C", MinTemp = "13°C", Cloudiness = "50% Cloudy", Sunrise = "5:15 AM", Sunset = "6:30 PM", Pressure = "1017 hPa" },
            };
        }
    }
}
