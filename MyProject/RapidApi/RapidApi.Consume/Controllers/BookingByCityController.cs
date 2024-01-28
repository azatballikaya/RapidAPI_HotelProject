using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApi.Consume.Models;

namespace RapidApi.Consume.Controllers
{
    public class BookingByCityController : Controller
    {
        public async Task<IActionResult> Index(string CityId)
        {
            if(!string.IsNullOrEmpty(CityId))
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v2/hotels/search?room_number=1&adults_number=2&checkout_date=2024-02-15&filter_by_currency=TRY&units=metric&locale=en-gb&checkin_date=2024-02-01&dest_type=city&dest_id={CityId}&order_by=popularity&children_ages=5%2C0&children_number=2&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0"),
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
                    var value = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(value.results.ToList());
                }
            }
            else
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("https://booking-com.p.rapidapi.com/v2/hotels/search?room_number=1&adults_number=2&checkout_date=2024-02-15&filter_by_currency=TRY&units=metric&locale=en-gb&checkin_date=2024-02-01&dest_type=city&dest_id=-755070&order_by=popularity&children_ages=5%2C0&children_number=2&include_adjacency=true&categories_filter_ids=class%3A%3A2%2Cclass%3A%3A4%2Cfree_cancellation%3A%3A1&page_number=0"),
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
                    var value = JsonConvert.DeserializeObject<BookingApiViewModel>(body);
                    return View(value.results.ToList());
                }
            }

        }
    }
}
