using MonkeyFinder.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http.Json;
using System.Text.Json;

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

            //using var stream = await FileSystem.OpenAppPackageFileAsync("monkeydata.json");
            //using var reader = new StreamReader(stream);
            //var contents = await reader.ReadToEndAsync();
            //monkeyList = JsonSerializer.Deserialize<List<Monkey>>(contents);

            return monkeyList;


        }
    }
}
