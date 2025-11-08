using Microsoft.AspNetCore.Mvc;
using ViewComponentsExample.Models;
namespace ViewComponentsExample.ViewComponents
{
    //[ViewComponent]
    public class GridViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() 
        {
            PersonGridModel model = new PersonGridModel
            {
                GridTitle = "Team Members",
                People = new List<Person>
                {
                    new Person { PersonName = "Alice Johnson", JobTitle = "Project Manager" },
                    new Person { PersonName = "Bob Smith", JobTitle = "Software Engineer" },
                    new Person { PersonName = "Charlie Brown", JobTitle = "UX Designer" },
                    new Person { PersonName = "Diana Prince", JobTitle = "QA Specialist" }
                }
            };
            ViewData["Grid"] = model;
            return View();
        }
    }
}
