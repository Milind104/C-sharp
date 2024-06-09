
using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using WeatherApp.MVVM.Models;

namespace WeatherApp.API
{
    public static class APIData
    {
        private const string ApiKey = "285c351950be99a30e0dc1efd8873afc"; // Replace with your actual API key
        private static readonly HttpClient HttpClient = new HttpClient();

        public static async Task<Root> GetWeatherData(double latitude, double longitude)
        {
            string url = $"https://api.openweathermap.org/data/2.5/forecast?lat={latitude}&lon={longitude}&appid={ApiKey} ";
            var response = await HttpClient.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<Root>(response);
            return result;
        }

        public static async Task<Root> GetWeatherDataByCity(string city)
        {
            string url = $"https://api.openweathermap.org/data/2.5/forecast?q={city}&appid={ApiKey} ";
            var response = await HttpClient.GetStringAsync(url);
            var result = JsonConvert.DeserializeObject<Root>(response);
            return result;
        }

        



    }
}
