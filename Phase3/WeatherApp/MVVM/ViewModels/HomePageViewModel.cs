using System;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using WeatherApp.API;
using WeatherApp.MVVM.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WeatherApp.MVVM.ViewModels
{
    public partial class HomePageViewModel : ObservableObject
    {
        [ObservableProperty]
        private string cityName;

        [ObservableProperty]
        private string weatherInfo;

        [ObservableProperty]
        private string cloudImage;

        [ObservableProperty]
        private string temp;

        [ObservableProperty]
        private string speed;

        [ObservableProperty]
        private string humidity;

        private double latitude;
        private double longitude;

        public ObservableCollection<ListData> ListDatas { get; } = new ObservableCollection<ListData>();

        public HomePageViewModel()
        {
        }

        [RelayCommand]
        private async Task GetLocationAsync()
        {
            try
            {
                var location = await Geolocation.GetLocationAsync();
                if (location != null)
                {
                    latitude = location.Latitude;
                    longitude = location.Longitude;
                    await GetWeatherDataAsync(latitude, longitude);
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Unable to get location", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Unable to get location: {ex.Message}", "OK");
            }
        }

        [RelayCommand]
        private async Task GetWeatherByCityAsync()
        {
            var city = await Application.Current.MainPage.DisplayPromptAsync("CityName", "Enter City Name", placeholder: "Enter City Name", accept: "Search", cancel: "Cancel");

            if (!string.IsNullOrWhiteSpace(city))
            {
                try
                {
                    var root = await APIData.GetWeatherDataByCity(city);
                    UpdateWeatherData(root);
                }
                catch (Exception ex)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", $"Unable to get weather data for {city}: {ex.Message}", "OK");
                }
            }
        }

        private async Task GetWeatherDataAsync(double latitude, double longitude)
        {
            try
            {
                var root = await APIData.GetWeatherData(latitude, longitude);
                UpdateWeatherData(root);
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", $"Unable to get weather data: {ex.Message}", "OK");
            }
        }

        private void UpdateWeatherData(Root root)
        {
            ListDatas.Clear();

            foreach (var item in root.List)
            {
                ListDatas.Add(item);
            }

            CityName = root.City.Name;
            WeatherInfo = root.List[0].Weather[0].Description;
            CloudImage = root.List[0].Weather[0].ImageUrl;
            Humidity = $"{root.List[0].Main.Humidity}%";
            Temp = $"{root.List[0].Main.Temp}°F";
            Speed = $"{root.List[0].Wind.Speed} km/h";
        }
    }
}
