using Microsoft.AspNetCore.Mvc;

namespace KestrelService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
