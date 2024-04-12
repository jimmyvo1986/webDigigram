using Microsoft.AspNetCore.Mvc;

namespace webDigigram.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
