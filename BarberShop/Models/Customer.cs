﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Barber_shop.Models
{
    public class Customer
    {
        [Required]
        public byte Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string  Surname { get; set; }

        [Required]
       
        public int Number { get; set; }

        public Booking Booking { get; set; }

        public byte BookingId { get; set; }

    }
}
