using ASP.NET_Core_Identity_Demo.Models.API_Demo;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;

namespace ASP.NET_Core_Identity_Demo.Controllers
{
    public class APIDemoController : Controller
    {
        public IActionResult Index()
        {
            var client = new HttpClient();
            var chuck = new ChuckNorris_Response();
            var kanye = new Kanye_Response();
            var ron = new Ron_Response();
            var viewModel = new Ron_Kanye_And_Chuck_ViewModel();

            var chuckURL = "https://api.chucknorris.io/jokes/random";
            var kanyeURL = "https://api.kanye.rest/";
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";

            string chuckResponse = client.GetStringAsync(chuckURL).Result;
            chuck = JsonConvert.DeserializeObject<ChuckNorris_Response>(chuckResponse);

            string kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            kanye.Quote = kanyeResponse;

            string ronResponse = client.GetStringAsync(ronURL).Result;
            ron.Quote = ronResponse;

            viewModel.Chuck = chuck;
            viewModel.Kanye = kanye;
            viewModel.Ron = ron;

            return View(viewModel);
        }
    }
}
