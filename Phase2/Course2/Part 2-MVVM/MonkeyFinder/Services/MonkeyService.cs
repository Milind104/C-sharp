using MonkeyFinder.Model;
using System.Net.Http.Json;

namespace MonkeyFinder.Services
{
    public class MonkeyService
    {
        List<Monkey> monkeyList = new List<Monkey>();

        HttpClient httpClient;
        public MonkeyService() 
        {
            this.httpClient = new HttpClient();

        }

        public async Task<List<Monkey>> GetMonkeys()
        {
            if(monkeyList.Count > 0)
                return monkeyList;

            var response = await httpClient.GetAsync("https://www.montemagno.com/monkeys.json");

            if (response.IsSuccessStatusCode)
            {
                monkeyList = await response.Content.ReadFromJsonAsync<List<Monkey>>();
            }

            /* using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydat.json");
             using var reader = new StreamReader(stream);
             var content = await reader.ReadToEndAsync();
             monkeyList = JsonSerializer.Deserialize<List<Monkey>>(content);*/

            return monkeyList;
        }
    }
}
