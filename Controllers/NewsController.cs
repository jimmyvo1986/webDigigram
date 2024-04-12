using Microsoft.AspNetCore.Mvc;

namespace webDigigram.Controllers
{
    public class NewsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
