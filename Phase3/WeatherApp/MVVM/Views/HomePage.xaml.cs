using WeatherApp.API;
using WeatherApp.MVVM.Models;

namespace WeatherApp.MVVM.Views;

public partial class HomePage : ContentPage
{
    List<ListData> listDatas;
    double latitude;
    double longitude;
	public HomePage()
	{
		InitializeComponent();
        listDatas = new List<ListData>();
	}

    protected async override void OnAppearing()
    {
        base.OnAppearing();

        await GetCurrentDeviceLocation();
        await GetWheatherData(latitude, longitude);

        
    }

    private async Task GetCurrentDeviceLocation()
    {
        var location = await Geolocation.GetLocationAsync();
        latitude = location.Latitude;
        longitude=location.Longitude;
    }

    private async void Button_Clicked(object sender, EventArgs e)
    {
        await GetCurrentDeviceLocation();
        await GetWheatherData(latitude, longitude);
    }

    private async Task GetWheatherData(double latitude, double longitude)
    {
        var root = await APIData.GetWeatherData(latitude, longitude);

        listDatas.Clear();

        foreach (var item in root.List)
        {
            listDatas.Add(item);
        }
        hDataList.ItemsSource = null;
        hDataList.ItemsSource = listDatas;

        CityNameLbl.Text = root.City.Name;
        weatherInfolbl.Text = root.List[0].Weather[0].Description;
        CloudImage.Source = root.List[0].Weather[0].ImageUrl;

        humiditylbl.Text = root.List[0].Main.Humidity + "%";
        templbl.Text = root.List[0].Main.Temp + "°F";
        speedlbl.Text = root.List[0].Wind.Speed + "km/h";

    }
}