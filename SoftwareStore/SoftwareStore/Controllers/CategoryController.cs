using Microsoft.AspNetCore.Mvc;

namespace SoftwareStore.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
