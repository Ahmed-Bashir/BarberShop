using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Barber_shop.Models
{
    public class Booking
    {
        public byte Id { get; set; }

        public DateTime Date { get; set; }

        public DateTime Time { get; set; }
    }
}
