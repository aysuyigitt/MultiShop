using Microsoft.AspNetCore.Mvc;
using MultiShop.RapidApiWebUI.Models;
using Newtonsoft.Json;

namespace MultiShop.RapidApiWebUI.Controllers
{
    public class DefaultController : Controller
    {
        public async Task<IActionResult> WeatherDetail()
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://weather-api99.p.rapidapi.com/weather?city=ankara"),
                Headers =
    {
        { "x-rapidapi-key", "b1faf14091msh99472d3ba21e643p115225jsnfb6a7d674f6f" },
        { "x-rapidapi-host", "weather-api99.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<WeatherViewModel.Rootobject>(body);
                ViewBag.cityTemp = values.data.temp;
                return View();
            }

        }
        public async Task<IActionResult> EXchange()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-finance-data.p.rapidapi.com/currency-exchange-rate?from_symbol=USD&language=en&to_symbol=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "b1faf14091msh99472d3ba21e643p115225jsnfb6a7d674f6f" },
        { "x-rapidapi-host", "real-time-finance-data.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ExchangeViewModel.Rootobject>(body);
                ViewBag.exchangeRateUsd = values.data.exchange_rate;
                ViewBag.previous_closeUsd = values.data.previous_close;

            }

            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://real-time-finance-data.p.rapidapi.com/currency-exchange-rate?from_symbol=EUR&language=en&to_symbol=TRY"),
                Headers =
    {
        { "x-rapidapi-key", "b1faf14091msh99472d3ba21e643p115225jsnfb6a7d674f6f" },
        { "x-rapidapi-host", "real-time-finance-data.p.rapidapi.com" },
    },
            };
            using (var response = await client2.SendAsync(request2))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ExchangeViewModel.Rootobject>(body);
                ViewBag.exchangeRateEur = values.data.exchange_rate;
                ViewBag.previous_closeEur = values.data.previous_close;
                return View();
            }
        }

    }
}