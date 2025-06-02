using Microsoft.AspNetCore.Mvc;

namespace SoftwareStore.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
