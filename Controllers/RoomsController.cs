using Microsoft.AspNetCore.Mvc;

namespace hotel.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
