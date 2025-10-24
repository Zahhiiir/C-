using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using ViewsExample.Models;
using static ViewsExample.Models.Person;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ViewsExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            ViewData["Message"] = "Welcome to the Home Page!";

            List<Person> people = new()
            {
                new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male },
                new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female },
                new Person() { Name = "Susan", DateOfBirth = DateTime.Parse("2008-07-12"), PersonGender = Gender.Other }
            };

            return View("Index", people);
        }
        [Route("/person-details/{name}")]
        public IActionResult Details(string? name)
        {
            List<Person> people = new()
            {
                new Person() { Name = "John", DateOfBirth = DateTime.Parse("2000-05-06"), PersonGender = Gender.Male },
                new Person() { Name = "Linda", DateOfBirth = DateTime.Parse("2005-01-09"), PersonGender = Gender.Female },
                new Person() { Name = "Susan", DateOfBirth = DateTime.Parse("2008-07-12"), PersonGender = Gender.Other }
            };

            if (name == null)
            {
                return Content("Person name is required.");
            }

            Person? matchingPerson = people.Where(p => p.Name != null && p.Name.Equals(name, StringComparison.OrdinalIgnoreCase)).FirstOrDefault();

            if (matchingPerson == null)
            {
                return NotFound($"Person with name '{name}' not found.");
            }
            return View(matchingPerson);
        }
        [Route("/person-with-product")]
        public IActionResult PersonWithProduct()
        {
            Person person = new()
            {
                Name = "Alice",
                DateOfBirth = DateTime.Parse("1995-03-15"),
                PersonGender = Gender.Male,
            };
            Product product = new()
            {
                Id = 101,
                ProductName = "Laptop",
                Price = 999.99m
            };
            PersonAndProductWrapperModel wrapperModel = new()
            {
                PersonData = person,
                ProductData = product
            };
            return View(wrapperModel);
        }
    }  
}
