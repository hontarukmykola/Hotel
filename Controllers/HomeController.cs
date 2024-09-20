using hotel.Data;
using hotel.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hotel.Controllers
{
    public class HomeController : Controller
    {
        private readonly HotelDbContext context;

        public HomeController(HotelDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var rooms = context.HotelRooms.ToList();
            return View(rooms);

        }

        public IActionResult Privacy()  
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}