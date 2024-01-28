using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi.Consume.Models;

namespace RapidApi.Consume.Controllers
{
    public class SearchLocationIdController : Controller
    {
        public async Task<IActionResult> Index(string cityName)
        {
            if (!string.IsNullOrEmpty(cityName))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={cityName}&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "88d080d380msh6f288498003eaf9p1bb5e6jsn9286ea45cf96" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    var value = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                    return View(value);
                }
            }
            else
            {
                 var client = new HttpClient();
                    var request = new HttpRequestMessage
                    {
                        Method = HttpMethod.Get,
                        RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name=istanbul&locale=en-gb"),
                        Headers =
    {
        { "X-RapidAPI-Key", "88d080d380msh6f288498003eaf9p1bb5e6jsn9286ea45cf96" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                    };
                    using (var response = await client.SendAsync(request))
                    {
                        response.EnsureSuccessStatusCode();
                        var body = await response.Content.ReadAsStringAsync();
                        var value = JsonConvert.DeserializeObject<List<BookingApiLocationSearchViewModel>>(body);
                        return View(value);
                    }
                }

            }
        }
    }
