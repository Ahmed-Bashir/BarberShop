﻿using BarberShop.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barber_shop.Models
{
    public class Booking
    {
       
        public byte Id { get; set; }

        [Required]
        public DateTime Date { get; set; }

        public DateTime Time { get; set; }

        public Customer Customer { get; set; }

        public Menu Menu { get; set; }

        //watch entity relationship 


    }
}
