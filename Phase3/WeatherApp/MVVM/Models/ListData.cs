//using Microsoft.WindowsAppSDK.Runtime.Packages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.MVVM.Models
{
    public class ListData
    {
        [JsonProperty("dt")]
        public int Dt { get; set; }

        public string CurrentData => UtcTimeLibrary.UtcTimeStamp.ConvertToUtc(Dt);


        

        [JsonProperty("main")]
        public Main Main { get; set; }

        [JsonProperty("weather")]
        public List<Weather> Weather { get; set; }

        [JsonProperty("clouds")]
        public Clouds Clouds { get; set; }

        [JsonProperty("wind")]
        public Wind Wind { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("pop")]
        public double Pop { get; set; }

        [JsonProperty("sys")]
        public Sys Sys { get; set; }

        [JsonProperty("dt_txt")]
        public string DtTxt { get; set; }

        [JsonProperty("rain")]
        public Rain Rain { get; set; }
    }
}
