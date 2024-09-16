using AutoMapper;
using hotel.Data;
using hotel.Dtos;
using hotel.Entities;
using Microsoft.AspNetCore.Mvc;



namespace hotel.Controllers
{
    public class RoomsController : Controller
    {
        

        public HotelDbContext context;
        private readonly IMapper mapper;

        public RoomsController(IMapper mapper)
        {
            context= new HotelDbContext();
            this.mapper = mapper;
        }
        public IActionResult Index()
        {

            return View();
        }



        [HttpGet]
        public IActionResult Create()
        {

            ViewBag.CreateMode = true;
            return View("Upsert");
        }

        // POST - create object in db
        [HttpPost]

        public IActionResult Create(HotelRoomsDto model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.CreateMode = true;
                return View("Upsert", model);
            }
            var entity = mapper.Map<HotelRoom>(model);
            context.HotelRooms.Add(entity);
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }




        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = context.HotelRooms.Find(id);

            if (product == null) return NotFound();


            ViewBag.CreateMode = false;
            return View("Upsert", mapper.Map<HotelRoomsDto>(product));
        }

        [HttpPost]
        public IActionResult Edit(HotelRoomsDto model)
        {
            if (!ModelState.IsValid)
            {

                ViewBag.CreateMode = false;
                return View("Upsert", model);
            }

            context.HotelRooms.Update(mapper.Map<HotelRoom>(model));
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }


        public IActionResult Catalog()
        {
            var rooms = context.HotelRooms.ToList();
            return View(rooms);
        }
        public IActionResult Details(int id)
        {
            var product = context.HotelRooms.Find(id);

            if (product == null) return NotFound();

            return View(mapper.Map<HotelRoomsDto>(product));
        }

        public IActionResult Delete(int id)
        {
            var product = context.HotelRooms.Find(id);

            if (product == null) return NotFound(); // 404

            context.HotelRooms.Remove(product);
            context.SaveChanges();

            return RedirectToAction("Catalog");
        }
        


    }


 
}
