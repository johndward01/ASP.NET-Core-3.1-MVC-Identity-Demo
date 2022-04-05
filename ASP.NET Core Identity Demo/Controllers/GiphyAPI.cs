using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using System.Threading;

namespace ASP.NET_Core_Identity_Demo.Controllers
{
    public class GiphyAPI : Controller
    {
        public IActionResult Index()
        {            
            var client = new HttpClient();
            var url = "https://api.giphy.com/v1/gifs/search?api_key=IVv33It9Q4JM0mn8AfKlwxfLwkkY28yx&q=cat+meme&limit=25&offset=0&rating=pg-13&lang=en";
            var response = client.GetAsync(url).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            var data = JObject.Parse(json).GetValue("data");

            return View(data.ToString());
        }
    }
}
