using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RapidApiConsume.Models;

namespace RapidApiConsume.Controllers
{
    public class SearchLocationController : Controller
    {
        public async Task<IActionResult> Index(string CityName)
        {
            if (!string.IsNullOrEmpty(CityName))
            {

                List<SearchLocationViewModel> locationViewModels = new List<SearchLocationViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name={CityName}&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "dcf68d5f27mshcf51c7019f0d202p1d9c89jsn8a1543f6b4af" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    locationViewModels = JsonConvert.DeserializeObject<List<SearchLocationViewModel>>(body);
                    return View(locationViewModels.Take(1).ToList());

                }
            }

            else
            {

                List<SearchLocationViewModel> locationViewModels = new List<SearchLocationViewModel>();

                var client = new HttpClient();
                var request = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri($"https://booking-com.p.rapidapi.com/v1/hotels/locations?name=Berlin&locale=en-gb"),
                    Headers =
    {
        { "X-RapidAPI-Key", "dcf68d5f27mshcf51c7019f0d202p1d9c89jsn8a1543f6b4af" },
        { "X-RapidAPI-Host", "booking-com.p.rapidapi.com" },
    },
                };
                using (var response = await client.SendAsync(request))
                {
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    locationViewModels = JsonConvert.DeserializeObject<List<SearchLocationViewModel>>(body);
                    return View(locationViewModels.Take(1).ToList());

                }
            }

        }
    }
}
