using System;
using System.Collections.Generic;
using System.Globalization;
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

            var calender = new Models.Calendar();


            var viewModel = new MenuViewModel()
            {
                Barbers = barbers,
                Cuts = cuts,
                Calendar = calender

            };

                
                return View(viewModel);
        }
        // rethink database design 
        [HttpPost]
        public IActionResult Create(Booking booking, Order orders)
        {
            var bookingDB = _context.Bookings.FirstOrDefault(b => b.CustomersId == 1);
            
            var bookings = new Booking()
            {
                Date = booking.Date,
                CustomersId = 1,
                

            };

            if (bookingDB == null)
            {
                _context.Add(bookings);
                _context.SaveChanges();

                orders.CustomersId = 1;


                _context.Add(orders);
                _context.SaveChanges();

            }



            return RedirectToAction("Index", "Menu");
        }
        
    }
}                       