using hotel.Data;
using hotel.Entities;
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

        public IActionResult Delete(int id)
        {
            var product = context.HotelRooms.Find(id);

            if (product == null) return NotFound(); // 404

            context.HotelRooms.Remove(product);
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        // POST - create object in db
        [HttpPost]

        public IActionResult Create(HotelRoom model)
        {   
            if (!ModelState.IsValid) return View(model);

            context.HotelRooms.Add(model);
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }
    }
}
