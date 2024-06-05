using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherApp.MVVM.Models;

namespace WeatherApp.API
{
    public static class APIData
    {
        

        public static async Task<Root> GetWeatherData( double latitude, double longitude)
        {
            HttpClient client = new HttpClient();

           var response= await client.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?lat={0}&lon={1}&appid=285c351950be99a30e0dc1efd8873afc",latitude,longitude));
           
            var result=JsonConvert.DeserializeObject<Root>(response);

            return result;
        }
    }
}
