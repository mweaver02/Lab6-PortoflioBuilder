using MaxWeaver_WebApp_Lab5.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace MaxWeaver_WebApp_Lab5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public HomeController(ILogger<HomeController> logger, IHttpClientFactory httpClientFactory)
        {
            _logger = logger;
            _httpClientFactory = httpClientFactory;
            Console.WriteLine("HERE");
        }

        public async Task<IActionResult> Students(int id)
        {
            Console.WriteLine("HERE2222");

            string uri;

            if(id > 0)
            {
                ViewData["Title"] = "Student Profile";
                uri = $"api/studentprofiles/?id={id}";
            }
            else
            {
                ViewData["Title"] = "All Profiles";
                uri = "api/studentprofiles/";
            }

            HttpClient client = _httpClientFactory.CreateClient(
                name: "StudentProfileWebApi");
            HttpRequestMessage request = new(method: HttpMethod.Get, requestUri: uri);

            HttpResponseMessage response = await client.SendAsync(request);

            IEnumerable<StudentProfile>? model = await response.Content.ReadFromJsonAsync<IEnumerable<StudentProfile>>();

            return View(model);
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private class StudentProfile
        {
        }
    }
}
