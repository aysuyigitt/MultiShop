using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApiWebUI.Models;
using Newtonsoft.Json;

namespace MultiShop.RapidApiWebUI.Controllers
{
    public class ECommerceController : Controller
    {
        public async Task<IActionResult> ECommerceList()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-product-search.p.rapidapi.com/search-v2?q=logitech%20fare&country=us&language=en&page=1&limit=10&sort_by=BEST_MATCH&product_condition=ANY"),
                Headers =
                {
                    { "x-rapidapi-key", "b1faf14091msh99472d3ba21e643p115225jsnfb6a7d674f6f" },
                    { "x-rapidapi-host", "real-time-product-search.p.rapidapi.com" },
                },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ECommerceViewModel>(body);

                // Product[] dizisini List<Product> tipine dönüştürüyoruz
                var productList = values.data.products.ToList();

                // Listeyi View'a gönderiyoruz
                return View(productList);
            }
        }
    }
}
