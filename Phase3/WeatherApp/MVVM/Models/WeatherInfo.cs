using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.MVVM.Models
{
    public class WeatherInfo
    {
        public string DayOfWeek { get; set; }
        public string WeatherIcon { get; set; }
        public string MaxTemp { get; set; }
        public string MinTemp { get; set; }
        public string Cloudiness { get; set; }

        public string Sunrise { get; set; }
        public string Sunset { get; set; }
        public string Pressure { get; set; }
    }
}
