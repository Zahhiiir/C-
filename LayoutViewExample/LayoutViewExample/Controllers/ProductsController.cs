using Microsoft.AspNetCore.Mvc;

namespace LayoutViewExample.Controllers
{
    public class ProductsController : Controller
    {
        [Route("/products")]
        public IActionResult Index()
        {
            return View();
        }
        //product id is optional
        [Route("/products/search/{ProductID}")]
        [Route("/products/search")]

        public IActionResult Search(int? ProductID)
        {
            ViewBag.ProductID = ProductID;
            return View();
        }
        [Route("/products/order")]
        public IActionResult Order()
        {
            return View();
        }

    }
}
