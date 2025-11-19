using Microsoft.AspNetCore.Mvc;
using Services;
using ServiceContract;

namespace DipendancyExample.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICitiesService _citiesService;

        public HomeController(ICitiesService citiesService)
        {
            _citiesService = citiesService;  //new ICitiesService();
        }
        [Route("/")]
        public IActionResult Index()
        {
           List<string>? Cities = _citiesService.GetCities();
            return View(Cities);
        }
    }
}
