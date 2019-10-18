using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Controllers.Dto
{
    public class BookingDto
    {
        [Required]
        public byte Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }
    }
}
