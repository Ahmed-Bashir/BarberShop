﻿using Barber_shop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BarberShop.Models
{
    public class MenuViewModel
    {

        public IEnumerable<Barber> Barbers { get; set; }

        public IEnumerable<Cut> Cuts { get; set; }

        public Booking Bookings { get; set; }

    }
}