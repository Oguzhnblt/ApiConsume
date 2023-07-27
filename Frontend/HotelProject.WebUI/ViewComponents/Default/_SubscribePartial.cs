using HotelProject.WebUI.DTOs.SubscribeDTO;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.ViewComponents.Default
{
    public class _SubscribePartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _SubscribePartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5079/api/Subscribe");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CreateSubscribeDTO>>(jsonData);
                return View(values);
            }

            return View();

        }
    }
}
