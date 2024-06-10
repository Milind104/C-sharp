using System;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using WeatherApp.MVVM.Models;

namespace WeatherApp.MVVM.ViewModels
{
    public partial class SevenDayWeatherViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<WeatherInfo> sevenDayWeather;

        [ObservableProperty]
        private string sunriseTime;

        [ObservableProperty]
        private string sunsetTime;

        [ObservableProperty]
        private string pressure;

        public SevenDayWeatherViewModel()
        {
            LoadWeatherData();
            NavigateBackCommand = new RelayCommand(NavigateBack);
        }

        private void LoadWeatherData()
        {
            // Dummy weather data for 7 days
            var weatherData = new ObservableCollection<WeatherInfo>
            {
                new WeatherInfo { DayOfWeek = "Monday", MaxTemp = "30°C", MinTemp = "20°C", WeatherIcon = "w_01d.png", Cloudiness = "Clear Sky", Sunrise = "5:00 AM", Sunset = "7:00 PM", Pressure = "1013" },
                new WeatherInfo { DayOfWeek = "Tuesday", MaxTemp = "28°C", MinTemp = "18°C", WeatherIcon = "w_02d.png", Cloudiness = "Partly Cloudy", Sunrise = "5:01 AM", Sunset = "7:01 PM", Pressure = "1015" },
                new WeatherInfo { DayOfWeek = "Wednesday", MaxTemp = "25°C", MinTemp = "17°C", WeatherIcon = "w_03d.png", Cloudiness = "Rain Showers", Sunrise = "5:02 AM", Sunset = "7:02 PM", Pressure = "1010" },
                new WeatherInfo { DayOfWeek = "Thursday", MaxTemp = "27°C", MinTemp = "19°C", WeatherIcon = "w_04d.png", Cloudiness = "Clear Sky", Sunrise = "5:03 AM", Sunset = "7:03 PM", Pressure = "1012" },
                new WeatherInfo { DayOfWeek = "Friday", MaxTemp = "29°C", MinTemp = "21°C", WeatherIcon = "w_05d.png", Cloudiness = "Partly Cloudy", Sunrise = "5:04 AM", Sunset = "7:04 PM", Pressure = "1011" },
                new WeatherInfo { DayOfWeek = "Saturday", MaxTemp = "31°C", MinTemp = "22°C", WeatherIcon = "w_09d.png", Cloudiness = "Clear Sky", Sunrise = "5:05 AM", Sunset = "7:05 PM", Pressure = "1014" },
                new WeatherInfo { DayOfWeek = "Sunday", MaxTemp = "32°C", MinTemp = "23°C", WeatherIcon = "w_10d.png", Cloudiness = "Thunderstorms", Sunrise = "5:06 AM", Sunset = "7:06 PM", Pressure = "1013" }
            };

            SevenDayWeather = weatherData;

            // Use the data from the first day for sunrise, sunset, and pressure
            SunriseTime = weatherData[0].Sunrise;
            SunsetTime = weatherData[0].Sunset;
            Pressure = $"{weatherData[0].Pressure} hPa";

          
    }
        // Command to navigate back to the home page
        public IRelayCommand NavigateBackCommand { get; }

        private async void NavigateBack()
        {
            // Logic to navigate back to the home page
            await Shell.Current.GoToAsync("//HomePage");
        }

    }
}
