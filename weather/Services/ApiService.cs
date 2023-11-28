using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using weather.Models;

namespace weather.Services
{
    public static class ApiService
    {
        public static async Task<Root> Getweather(double latitude, double longitude)
        {
            var HttpClient = new HttpClient();
            var response = await HttpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q=Taichung&units=metric&appid=2d98d46ffd10b4d44d515201d4a83f5f"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
        public static async Task<Root>GetweatherByCity(string city)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(string.Format("https://api.openweathermap.org/data/2.5/forecast?q=Taichung&units=metric&appid=2d98d46ffd10b4d44d515201d4a83f5f"));
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
}
