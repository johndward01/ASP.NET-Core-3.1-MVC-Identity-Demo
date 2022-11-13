using ASP.NET_Core_Identity_Demo.Models.Aviation;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace ASP.NET_Core_Identity_Demo.Controllers
{
    public class Aviation : Controller
    {
        public IActionResult Index()
        {
            var client = new HttpClient();
            var root = new Root();
            var url = "http://api.aviationstack.com/v1/flights?access_key=14e0430e92634dc857caa1f837598e0d";
            var response = client.GetStringAsync(url).Result;
            root = JsonConvert.DeserializeObject<Root>(response);
            return View(root);
        }
    }
}
