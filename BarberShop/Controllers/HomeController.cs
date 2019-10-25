using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BarberShop.Models;
using Barber_shop.Models;

namespace BarberShop.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BarberShopDbContext _context;

        public HomeController(ILogger<HomeController> logger, BarberShopDbContext context )
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var dbCustomer = _context.Customers.SingleOrDefault(c => c.Id == 1);

            return View(dbCustomer);
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
