using ASP.NET_Core_Identity_Demo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using Newtonsoft.Json;

namespace ASP.NET_Core_Identity_Demo.Controllers
{
    public class OpenWeatherMap : Controller
    {
        public IActionResult Index()
        {
            var weather = new Root();
            return View(weather);
        }

        [HttpPost]
        public IActionResult GetWeather(Root rootWeather)
        {               
            var client = new HttpClient();
            var forecast = $"https://api.openweathermap.org/data/2.5/forecast?q={rootWeather.City.Name}&appid={rootWeather.API_Key}&units=imperial";
            var response = client.GetStringAsync(forecast);
            rootWeather = JsonConvert.DeserializeObject<Root>(response.Result);

            return View(rootWeather);
        }

    }
}
