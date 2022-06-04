using Microsoft.AspNetCore.Mvc;

namespace MedicReach.Controllers
{
    public class TinTucController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
