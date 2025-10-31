using Microsoft.AspNetCore.Mvc;
using PartialViewsExample.Models;

namespace PartialViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        [Route("/home")]
        public IActionResult Index()
        {
            ListModel model = new ListModel();
            return View(model);
        }
        [Route("/about")]
        public IActionResult About()
        {
            return View();
        }
        [Route("/programming-languages")]
        public IActionResult ProgrammingLanguages()
        {
            // Simplified collection initialization
            ListModel listmodel = new ListModel
            {
                ListTitle = "Programming Languages",
                ListItems = new List<string>
                    {
                        "C#",
                        "Java",
                        "Python",
                        "JavaScript",
                        "Go",
                        "Ruby"
                    }
            };

            return PartialView("_ListPartialView",listmodel); // Pass the model to the view
        }
    }
}
