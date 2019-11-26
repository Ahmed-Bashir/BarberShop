using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Barber_shop.Models;
using BarberShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BarberShop.Controllers
{
    public class MenuController : Controller
    {
        private BarberShopDbContext _context;
        public MenuController(BarberShopDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var barbers = _context.Barbers.ToList();
            var cuts = _context.Cuts.ToList();
            var bookings = new Booking();

            var viewModel = new MenuViewModel()
            {
                Barbers = barbers,
                Cuts = cuts,
                Bookings = bookings

            };

                
                return View(viewModel);
        }
        // rethink database design 
        [HttpPost]
        public IActionResult Create(MenuViewModel viewModel)
        {
         var barber = _context.Barbers.SingleOrDefault(b => b.Id == viewModel.Barbers.)

            return null;
        }
    }
}