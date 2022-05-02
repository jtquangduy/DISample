using DISample.Services;
using Microsoft.AspNetCore.Mvc;

namespace DISample.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index([FromServices]IProductService productService)
        {
            var products = productService.GetAll();
            return View(products);
        }
    }
}