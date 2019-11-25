using Barber_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public class Order
    {
        public int Id { get; set; }
        public Booking Bookings { get; set; }
        public int BookingsId { get; set; }
        public Customer Customers { get; set; }
        public int CustomersId { get; set; }
        public Barber Barbers { get; set; }
        public int BarbersId { get; set; }
        public Cut Cuts { get; set; }
        public int CutsId { get; set; }

    }
}
