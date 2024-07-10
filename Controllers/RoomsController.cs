using hotel.Data;
using Microsoft.AspNetCore.Mvc;

namespace hotel.Controllers
{
    public class RoomsController : Controller
    {
        public HotelDbContext context;
        public RoomsController()
        {
            context= new HotelDbContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            var rooms = context.HotelRooms.ToList();
            return View(rooms);
        }

    }
}
