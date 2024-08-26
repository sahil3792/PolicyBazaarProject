using Microsoft.AspNetCore.Mvc;

namespace PolicyBazaar.Controllers
{
    public class IndexController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
