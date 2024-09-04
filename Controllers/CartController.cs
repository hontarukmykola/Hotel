using Microsoft.AspNetCore.Mvc;

namespace hotel.Controllers
{
    public class CartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Add(int id)
        {
            
            List<int> ids = new List<int>();
            ids.Add(id);

            return View();
        }

        public IActionResult Remove()
        {
            return View();
        }
    }
}
