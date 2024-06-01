namespace MauiApp4;
using System.Text.Json;

public partial class ToonPage : ContentPage
{
	public ToonPage()
	{
		InitializeComponent();
        GetToonsAsync();

        
    }

    public async void GetToonsAsync()
    {
        HttpClient client = new HttpClient();
        var stream = client.GetStreamAsync("https://apipool.azurewebsites.net/api/toons");
        var data = await JsonSerializer.DeserializeAsync<Toon[]>(await stream);
        Dispatcher.Dispatch(() => cvToons.ItemsSource = data);
    }
}