using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barber_shop.Models
{
    public class Customer
    {
        public byte Id { get; set; }

        public string Name { get; set; }
        public string  Surname { get; set; }

        public int Number { get; set; }

        public Booking Booking { get; set; }

        public byte BookingId { get; set; }

    }
}
