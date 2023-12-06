using Microsoft.AspNetCore.Mvc;

namespace ProductifyMvc.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult GetAll()
        {
            return View();
        }

        public IActionResult AddProduct()
        {
            return View();
        }
    }
}
