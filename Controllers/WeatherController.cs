using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RuralWeather.Models;
using System.Diagnostics;

namespace RuralWeather.Controllers {
    public class WeatherController : Controller {
        private readonly ILogger<WeatherController> _logger;

        private readonly HttpClient _httpClient;
        public WeatherController(ILogger<WeatherController> logger, HttpClient httpClient) {
            _logger = logger;
            _httpClient = httpClient;
        }

        public async Task<IActionResult> Index() {
            // Fetch data from API or hardcoded JSON
            var json = await _httpClient.GetStringAsync("http://api.weatherapi.com/v1/forecast.json?key=1b814f213ffd4cfbab281025242008&q=London&days=1&aqi=yes&alerts=yes");

            var weatherData = JsonConvert.DeserializeObject<WeatherData>(json);

            return View(weatherData);
            //return View();
        }

        public IActionResult Privacy() {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
