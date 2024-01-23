using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi.Consume.Models;
using System.Text.Json.Serialization;

namespace RapidApi.Consume.Controllers
{
    public class ImdbController : Controller
    {
        public async Task<IActionResult> Index()
        {
            
            List<ApiMovieViewModel> list = new List<ApiMovieViewModel>();
          
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://imdb-top-100-movies.p.rapidapi.com/"),
                Headers =
    {
        { "X-RapidAPI-Key", "88d080d380msh6f288498003eaf9p1bb5e6jsn9286ea45cf96" },
        { "X-RapidAPI-Host", "imdb-top-100-movies.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var value= JsonConvert.DeserializeObject<List<ApiMovieViewModel>>(body);
                return View(value);
            }



        }
    }
}
