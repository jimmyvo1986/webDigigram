using Microsoft.AspNetCore.Mvc;

namespace webDigigram.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
