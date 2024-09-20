using AutoMapper;
using hotel.Data;
using hotel.Dtos;
using hotel.NewFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace hotel.Controllers
{
    public class CartController : Controller
    {
        private HotelDbContext context = new();
        private readonly IMapper mapper;
        public CartController(IMapper mapper)
        {
            this.mapper = mapper;
        }
        // відображає сторінку корзини із доданими продуктами
        public IActionResult Index()
        {
            var ids = HttpContext.Session.Get<List<int>>("cart_items") ?? new();
            var products = context.HotelRooms.Where(x => ids.Contains(x.Id)).ToList();
            return View(mapper.Map<List<HotelRoomsDto>>(products));
        }
        // додає продукт в корзину
        public IActionResult Add(int id)
        {
            // зчитуємо наявні елементи в корзині
            var ids = HttpContext.Session.Get<List<int>>("cart_items");
            // якщо елементів немає, тоді створюємо порожній список
            if (ids == null) ids = new();
            // додаємо новий елемент
            ids.Add(id);
            // зберігаємо оновлений список корзини в cookies
            HttpContext.Session.Set("cart_items", ids);
            return RedirectToAction("Index");
        }
        // видаляє продукт з корзини
        public IActionResult Remove()
        {
            return View();
        }
    }
}
