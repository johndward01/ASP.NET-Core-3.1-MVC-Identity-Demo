using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Net.Http;

namespace ASP.NET_Core_Identity_Demo.Controllers
{
    public class GiphyAPI : Controller
    {
        public IActionResult Index()
        {
            var config = new ConfigurationBuilder();

            var url = "https://api.giphy.com/v1/gifs/search?api_key=IVv33It9Q4JM0mn8AfKlwxfLwkkY28yx&q=cat+meme&limit=25&offset=0&rating=pg-13&lang=en";

            return View();
        }
    }
}
